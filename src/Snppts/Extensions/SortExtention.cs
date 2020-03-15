using Newtonsoft.Json;
using Snppts.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Snppts.Extensions
{
    public static class SortExtention
    {
        public static List<GitHubRepoInfo> GitHubRepos { get; set; }

        public static async Task<IList<IAmASnippet>> SortSnippets(this IList<IAmASnippet> members, SortType sortType = SortType.stars, int page = 1)
        {
            var api = "https://api.github.com/search/repositories?q=repo:";

            var last = members.LastOrDefault();

            foreach (var item in members)
            {
                if (!item.Equals(last))
                    api += item.GitHubRepoInfo.GitHubRepoName + "+repo:";

                else
                {
                    switch (sortType)
                    {
                        case SortType.stars:
                            api += item + "&sort=star";
                            break;
                        case SortType.updated:
                        default:
                            api += item + "&sort=updated";
                            break;
                    }

                    api += "&page="+ page;
                }
            }

            var list = await SortService.Get(api);
            GitHubRepos = list.Items;

            switch (sortType)
            {
                case SortType.stars:
                    return members.OrderStar().Select(x => x.Snippet).ToList();

                case SortType.updated:
                default:
                    return members.OrderUpdated().Select(x => x.Snippet).ToList();
            }
        }

        public static List<SnpptsWithGitHubValues> OrderUpdated(this IList<IAmASnippet> items)
        {
            var listReturn = new List<SnpptsWithGitHubValues>();

            foreach (var item in items)
            {
                var model = GitHubRepos.FirstOrDefault(x => x.FullName.ToLower().Equals(item.GitHubRepoInfo.GitHubRepoName.ToLower()));

                if (!string.IsNullOrEmpty(model?.FullName))
                {
                    listReturn.Add(new SnpptsWithGitHubValues
                    {
                        Snippet = item,
                        Update = model.UpdatedAt
                    });
                }
            }

            return listReturn.OrderByDescending(x => x.Update).ToList();
        }

        public static List<SnpptsWithGitHubValues> OrderStar(this IList<IAmASnippet> items)
        {
            var listReturn = new List<SnpptsWithGitHubValues>();

            foreach (var item in items)
            {
                var model = GitHubRepos.FirstOrDefault(x => x.FullName.ToLower().Equals(item.GitHubRepoInfo.GitHubRepoName.ToLower()));

                if (!string.IsNullOrEmpty(model?.FullName))
                {
                    listReturn.Add(new SnpptsWithGitHubValues
                    {
                        Snippet = item,
                        Stars = model.Stars
                    });
                }
            }

            return listReturn.OrderByDescending(x => x.Stars).ToList();
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
                ghModel = await response.Content.ReadAsAsync<GitHubModel>();
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

        [JsonProperty("total_count")]
        public int TotalCount { get; private set; }

        [JsonProperty("items")]
        public List<GitHubRepoInfo> Items { get; private set; }
    }

    public class GitHubRepoInfo
    {
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

        [JsonProperty("full_name")]
        public string FullName { get; private set; }

        [JsonProperty("description")]
        public string Description { get; private set; }

        [JsonProperty("stargazers_count")]
        public int Stars { get; private set; }

        [JsonProperty("forks_count")]
        public int Forks { get; private set; }

        [JsonProperty("pushed_at")]
        public DateTime UpdatedAt { get; private set; }
    }
}
