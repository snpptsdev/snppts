namespace Snppts.Snippets;

public class MAUIsland : IAmASnippet
{
    public string Slug => "mauisland";

    public string Title => "MAUIsland";

    public string Description => "MAUIsland is a collection of native controls, helper functions, custom controls, and app services that come from built-in MAUI framework, Syncfusion and later MAUI Toolkit, Telerik and DevExpress will added. It simplifies and demonstrates common developer patterns when building experiences for crossplatform development. It contains components and helpers to give .NET developers have better times for what they need and interact with the real result that MAUI generated.";

    public GitHubRepoInfo GitHubRepoInfo => new GitHubRepoInfo("Strypper/mauisland");

    public Uri ExternalUri => new Uri("https://github.com/Strypper/mauisland");

    public bool ContainsAndroidSample => true;

    public bool ContainsiOSSample => true;

    public bool ContainsUWPSample => true;

    public Sdk BuiltWith => Sdk.Maui;

    public IAmAnAuthor AuthorInfo => new StrypperJason();

    public IEnumerable<Uri> ImageUris => new List<Uri>
    {
        new Uri("https://raw.githubusercontent.com/Strypper/mauisland/main/showcases/version_2.0/Screenshot%202024-04-15%20091625.png"),
        new Uri("https://github.com/Strypper/mauisland/blob/main/showcases/version_2.0/Screenshot%202024-04-15%20091700.png?raw=true"),
        new Uri("https://github.com/Strypper/mauisland/blob/main/showcases/version_2.0/Screenshot%202024-04-15%20092455.png?raw=true"),
        new Uri("https://github.com/Strypper/mauisland/blob/main/showcases/version_2.0/Screenshot%202024-04-15%20091726.png?raw=true"),
        new Uri("https://github.com/Strypper/mauisland/blob/main/showcases/version_2.0/Screenshot%202024-04-15%20092638.png?raw=true"),
        new Uri("https://github.com/Strypper/mauisland/blob/main/showcases/version_2.0/Screenshot%202024-04-15%20092715.png?raw=true"),
        new Uri("https://github.com/Strypper/mauisland/blob/main/showcases/version_2.0/Screenshot%202024-04-15%20092926.png?raw=true"),
    };


    public IList<Category> Categories => new List<Category>
    {
        Category.CHARTS,
        Category.LOGIN,
        Category.SETTINGS,
        Category.ACTIVITYFEEDS,
        Category.NAVIGATIONS,
        Category.SHARE,
        Category.SIGNUPS,
        Category.SOCIALNETWORK,
        Category.CARDS,
        Category.CAROUSEL,
        Category.PRODUCTS
    };
}