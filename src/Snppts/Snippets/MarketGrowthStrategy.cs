namespace Snppts.Snippets;

public class MarketGrowthStrategy : IAmASnippet
{
    public string Slug => "market-growth-strategy";
    public string Title => "Market Growth Strategy";
    public GitHubRepoInfo GitHubRepoInfo => new GitHubRepoInfo("Riccardo11/MarketGrowthStrategy");
    public Uri ExternalUri => null;
    public bool ContainsAndroidSample => true;
    public bool ContainsiOSSample => true;
    public bool ContainsUWPSample => false;
    public Sdk BuiltWith => Sdk.Maui;

    public string Description => "Simple replication of this design written in .NET MAUI: https://dribbble.com/shots/19153569-Mobile-App-iOS-Android-UI";
    public IAmAnAuthor AuthorInfo => new RiccardoMinato();

    public IEnumerable<Uri> ImageUris => new List<Uri>
    {
        new Uri("https://raw.githubusercontent.com/Riccardo11/MarketGrowthStrategy/master/images/Screenshot1.png"),
        new Uri("https://raw.githubusercontent.com/Riccardo11/MarketGrowthStrategy/master/images/Screenshot2.png"),
        new Uri("https://raw.githubusercontent.com/Riccardo11/MarketGrowthStrategy/master/images/Screenshot3.png")
    };

    public IList<Category> Categories => new List<Category>
    {
        Category.PROFILES,
        Category.DASHBOARD
    };
}