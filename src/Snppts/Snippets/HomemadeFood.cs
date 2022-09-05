namespace Snppts.Snippets;

public class homemadefood : IAmASnippet
{
    public string Slug => "homemadefood";

    public string Title => "Homemade Food";

    public string Description => "Recepies App for home cook";

    public GitHubRepoInfo GitHubRepoInfo => new GitHubRepoInfo("ahdbk/MAUI.RecipiesApp");

    public Uri ExternalUri => null;

    public bool ContainsAndroidSample => true;

    public bool ContainsiOSSample => true;

    public bool ContainsUWPSample => false;

    public Sdk BuiltWith => Sdk.Maui;

    public IAmAnAuthor AuthorInfo => new AhdBenKheder();

    public IEnumerable<Uri> ImageUris => new List<Uri>
    {
        new Uri("https://raw.githubusercontent.com/ahdbk/MAUI.RecipiesApp/master/screenshots/01.gif"),
        new Uri("https://raw.githubusercontent.com/ahdbk/MAUI.RecipiesApp/master/screenshots/01.png"),
        new Uri("https://raw.githubusercontent.com/ahdbk/MAUI.RecipiesApp/master/screenshots/02.png"),
        new Uri("https://raw.githubusercontent.com/ahdbk/MAUI.RecipiesApp/master/screenshots/03.png"),
        new Uri("https://raw.githubusercontent.com/ahdbk/MAUI.RecipiesApp/master/screenshots/04.png"),
    };

    public IList<Category> Categories => new List<Category>
    {
        Category.CAROUSEL,
        Category.NAVIGATIONS,
        Category.FILTER,
        Category.FILTER,
    };
}
