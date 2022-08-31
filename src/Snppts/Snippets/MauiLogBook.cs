namespace Snppts.Snippets;

public class MauiLogBook : IAmASnippet
{
    public string Slug => "Logbook for Vehicle";

    public string Title => "Vehicle Logbook";

    public string Description => "Logbook for collecting all trips";

    public GitHubRepoInfo GitHubRepoInfo => new GitHubRepoInfo("https://github.com/nehl-it/MauiLogbook");

    public Uri ExternalUri => null;

    public bool ContainsAndroidSample => true;

    public bool ContainsiOSSample => true;

    public bool ContainsUWPSample => false;

    public Sdk BuiltWith => Sdk.Maui;

    public IAmAnAuthor AuthorInfo => new DominikNehl();

    public IEnumerable<Uri> ImageUris => new List<Uri>()
    {
        new Uri("https://user-images.githubusercontent.com/40561661/187639753-5e180a03-a176-469c-9f27-5910c0635e12.png"),
        new Uri("https://user-images.githubusercontent.com/40561661/187639805-ddecec21-5ba3-4598-88fd-6e58b22b9b4d.png")
    };

    public IList<Category> Categories => new List<Category>
    {
        Category.PROFILES, Category.CARDS,
    };
}
