namespace Snppts.Snippets;

public class XamBookLibrary : IAmASnippet
{
    public string Slug => "xam-book-library";
    public string Title => "Awesome UI - Book Library";

    public GitHubRepoInfo GitHubRepoInfo => new GitHubRepoInfo("shanranm/XamBookLibrary");
    public bool ContainsAndroidSample => true;
    public bool ContainsiOSSample => true;
    public bool ContainsUWPSample => false;
    public Sdk BuiltWith => Sdk.XamarinForms;

    public string Description => "Neat Xamarin.Forms UI with simple animation";

    public IAmAnAuthor AuthorInfo => new ShanmukhaRanganath();

    public IEnumerable<Uri> ImageUris => new List<Uri>
    {
        new Uri("https://raw.githubusercontent.com/shanranm/XamBookLibrary/master/screens/recorded.gif")
    };

    public IList<Category> Categories => new List<Category>
    {
        Category.CARDS, Category.NAVIGATIONS
    };

    public Uri ExternalUri => null;
}
