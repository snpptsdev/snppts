namespace Snppts.Snippets;

public class LinkChecker : IAmASnippet
{
    public string Slug => "link-checker-charts";
    public string Title => "Link Checker Pie Chart";
    public GitHubRepoInfo GitHubRepoInfo => new ("NogginBox/Link-Checker-Samples");
    public bool ContainsAndroidSample => true;
    public bool ContainsiOSSample => true;
    public bool ContainsUWPSample => true;
    public Sdk BuiltWith => Sdk.Maui;

    public string Description => "A summary of figures using a pie chart made with LiveCharts2. Taken from my work in progress app Link Checker.";

    public IAmAnAuthor AuthorInfo => new RichardGarside();

    public IEnumerable<Uri> ImageUris => new List<Uri>
    {
        new Uri("https://github.com/NogginBox/Link-Checker-Samples/raw/main/Screenshots/Screenshot-Chart-01.png"),
    };

    public IList<Category> Categories => new List<Category>
    {
        Category.CHARTS
    };

    public Uri ExternalUri => null;
}
