namespace Snppts.Snippets;

public class MauiScientificCalculator : IAmASnippet
{
    public string Slug => "maui-sci-calc";
    public string Title => "Maui Scientific Calculator";
    public GitHubRepoInfo GitHubRepoInfo => new GitHubRepoInfo("naweed/MauiScientificCalculator");
    public bool ContainsAndroidSample => true;
    public bool ContainsiOSSample => true;
    public bool ContainsUWPSample => true;
    public bool ContainsmacOSSample => false;
    public Sdk BuiltWith => Sdk.Maui;

    public string Description => "This is a complete scientific calculator built using .NET MAUI. Based on the amazing Behance Concept (https://www.behance.net/gallery/79810231/UIUX-Challenge-04-05-Calculator-App-Icon).";

    public IAmAnAuthor AuthorInfo => new NaweedAkram();

    public IEnumerable<Uri> ImageUris => new List<Uri>
    {
        new Uri("https://github.com/naweed/MauiScientificCalculator/blob/main/CalcScreen.png?raw=true")
    };

    public IList<Category> Categories => new List<Category>
    {
        Category.CALCULATORS
    };

    public Uri ExternalUri => null;
}
