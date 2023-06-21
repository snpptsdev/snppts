namespace Snppts.Snippets;

public class MauiTrackizer : IAmASnippet
{
    public string Slug => "maui-trackizer";
    public string Title => "Maui Trackizer";
    public GitHubRepoInfo GitHubRepoInfo => new GitHubRepoInfo("chsakell/maui-trackizer");
    public bool ContainsAndroidSample => true;
    public bool ContainsiOSSample => true;
    public bool ContainsUWPSample => false;
    public Sdk BuiltWith => Sdk.Maui;

    public string Description => "A subscription tracking App UI, implemented by the MAUI cross-platform framework.";

    public IAmAnAuthor AuthorInfo => new ChristosSakellarios();

    public IEnumerable<Uri> ImageUris => new List<Uri>
    {
        new Uri("https://raw.githubusercontent.com/chsakell/maui-trackizer/main/docs/trackizer-app.gif")
    };

    public IList<Category> Categories => new List<Category>
    {
        Category.LISTS,
        Category.SETTINGS,
        Category.LOGIN,
        Category.LAUNCHSCREEN,
        Category.NAVIGATIONS,
        Category.CAROUSEL
    };

    public Uri ExternalUri => new Uri("https://github.com/chsakell/maui-trackizer");
}
