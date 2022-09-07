namespace Snppts.Snippets;

public class ChickAndPaddyMauiSample : IAmASnippet
{
    public string Slug => "chick-and-paddy-dotnet-maui";
    public string Title => "Chick and Paddy in MAUI";
    public string Description => "This snippet was created to demonstrate a well structured MAUI MVVM application. It uses feature-based, clean architecture and levarages all built-in MAUI controls.";
    public GitHubRepoInfo GitHubRepoInfo => new GitHubRepoInfo("tuyen-vuduc/chick-and-paddy-dotnet-maui");
    public bool ContainsAndroidSample => true;
    public bool ContainsiOSSample => true;
    public bool ContainsUWPSample => false;
    public Uri ExternalUri => new Uri("https://github.com/tuyen-vuduc/chick-and-paddy-dotnet-maui");
    public Sdk BuiltWith => Sdk.Maui;

    public IAmAnAuthor AuthorInfo => new TuyenVuDuc();

    public IEnumerable<Uri> ImageUris => new List<Uri>
    {
        new Uri("https://raw.githubusercontent.com/tuyen-vuduc/chick-and-paddy-dotnet-maui/main/docs/images/sign-in.png"),
        new Uri("https://raw.githubusercontent.com/tuyen-vuduc/chick-and-paddy-dotnet-maui/main/docs/images/sign-up.png"),
        new Uri("https://raw.githubusercontent.com/tuyen-vuduc/chick-and-paddy-dotnet-maui/main/docs/images/news-feeds.png"),
        new Uri("https://raw.githubusercontent.com/tuyen-vuduc/chick-and-paddy-dotnet-maui/main/docs/images/stories.png"),
    };

    public IList<Category> Categories => new List<Category>
    {
        Category.WALKTHROUGHS,
        Category.LOGIN,
        Category.SETTINGS,
        Category.ACTIVITYFEEDS,
        Category.NAVIGATIONS,
        Category.SHARE,
        Category.SIGNUPS,
        Category.SOCIALNETWORK,
    };
}