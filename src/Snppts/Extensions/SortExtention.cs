using System.Text.Json;
using System.Text.Json.Serialization;

namespace Snppts.Extensions;

public static class SortExtention
{
    public static List<GitHubRepoInfo> GitHubRepos { get; set; }

    public static async Task<IList<IAmASnippet>> SortSnippets(this IList<IAmASnippet> members, SortType sortType = SortType.stars, int page = 1, int per_page = 60)
    {
        var api = "https://api.github.com/search/repositories?q=";

        api += string.Join('+', members.Select(x => $"repo:{x.GitHubRepoInfo.GitHubRepoName}"));

        api += sortType switch
        {
            SortType.stars => "&sort=star",
            _ => "&sort=updated",
        };

        api += $"&per_page={per_page}&page={page}";

        var list = await SortService.Get(api);
        GitHubRepos = list.Items;

        var allNameRepoService = GitHubRepos.Select(x => x.FullName.ToLower());
        var result = members.Where(x => allNameRepoService.Contains(x.GitHubRepoInfo.GitHubRepoName.ToLower())).ToList();

        switch (sortType)
        {
            case SortType.stars:
                return result.OrderByDescending(x => x.GitHubRepoInfo.GetRepoInfoFromService(GitHubRepos).Stars).ToList();

            case SortType.updated:
            default:
                return result.OrderByDescending(x => x.GitHubRepoInfo.GetRepoInfoFromService(GitHubRepos).UpdatedAt).ToList();
        }
    }
}

public class SnpptsWithGitHubValues
{
    public IAmASnippet Snippet { get; set; }

    public int Stars { get; set; }

    public DateTime Update { get; set; }
}

public enum SortType
{
    updated,
    stars
}

public class SortService
{
    static readonly HttpClient client = new HttpClient();

    public static async Task<GitHubModel> Get(string path)
    {
        client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

        client.DefaultRequestHeaders.UserAgent.TryParseAdd("request");

        GitHubModel ghModel = new GitHubModel();

        HttpResponseMessage response = await client.GetAsync(path);

        if (response.IsSuccessStatusCode)
        {
            
            ghModel = await JsonSerializer.DeserializeAsync<GitHubModel>(await response.Content.ReadAsStreamAsync());
        }

        return ghModel;
    }
}

public class GitHubModel
{
    public GitHubModel()
    {
        Items = new List<GitHubRepoInfo>();
    }
    
    [JsonPropertyName("total_count")]
    public int TotalCount { get; set; }

    [JsonPropertyName("items")]
    public List<GitHubRepoInfo> Items { get; set; }
}

public class GitHubRepoInfo
{
    public GitHubRepoInfo() { }

    public GitHubRepoInfo(string _gitHubRepoName)
    {
        GitHubRepoName = _gitHubRepoName;
    }

    /// <summary>
    /// Unique info from Author the outhers properties is set from github api service
    /// </summary>
    public string GitHubRepoName { get; set; }

    //[JsonProperty("name")]
    //public string Name { get; private set; }

    [JsonPropertyName("full_name")]
    public virtual string FullName { get; set; }

    [JsonPropertyName("description")]
    public virtual string Description { get; set; }

    [JsonPropertyName("stargazers_count")]
    public virtual int Stars { get; set; }

    [JsonPropertyName("forks_count")]
    public virtual int Forks { get; set; }

    [JsonPropertyName("pushed_at")]
    public virtual DateTime UpdatedAt { get; set; }

    public GitHubRepoInfo GetRepoInfoFromService(List<GitHubRepoInfo> repoListFromService)
    {
        if (repoListFromService == null || repoListFromService.Count.Equals(0))
            return this;

        var obj = repoListFromService.FirstOrDefault(x => x.FullName.ToLower().Equals(this.GitHubRepoName.ToLower()));

        if (string.IsNullOrEmpty(obj?.FullName))
            return this;

        obj.GitHubRepoName = this.GitHubRepoName;
        return obj;
    }
}
