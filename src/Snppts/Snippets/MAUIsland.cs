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
        new Uri("https://github.com/Strypper/mauisland/blob/main/showcases/Screenshot%202023-02-15%20052323.png?raw=true"),
        new Uri("https://github.com/Strypper/mauisland/blob/main/showcases/Screenshot_1676259571.png?raw=true"),
        new Uri("https://github.com/Strypper/mauisland/blob/main/showcases/Screenshot_1676259831.png?raw=true"),
        new Uri("https://github.com/Strypper/mauisland/blob/main/showcases/projectmockup.png?raw=true"),
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