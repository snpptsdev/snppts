namespace Snppts.Snippets;

public class FancyTutorial : IAmASnippet
{
    public string Slug => "fancy-tutorial";
    public string Title => "Fancy Tutorial";
    public GitHubRepoInfo GitHubRepoInfo => new GitHubRepoInfo("sthewissen/KickassUI.FancyTutorial");
    public bool ContainsAndroidSample => true;
    public bool ContainsiOSSample => true;
    public bool ContainsUWPSample => false;
    public Sdk BuiltWith => Sdk.XamarinForms;

    public string Description => "A simple Xamarin.Forms tutorial screen as talked about in my blogpost.";

    public IAmAnAuthor AuthorInfo => new StevenThewissen();

    public IEnumerable<Uri> ImageUris => new List<Uri>
    {
        new Uri("https://raw.githubusercontent.com/sthewissen/KickassUI.FancyTutorial/master/ios.png"),
        new Uri("https://raw.githubusercontent.com/sthewissen/KickassUI.FancyTutorial/master/android.jpg")
    };

    public IList<Category> Categories => new List<Category>
    {
        Category.WALKTHROUGHS, Category.PHOTOS
    };

    public Uri ExternalUri => new Uri("https://www.thewissen.io/simple-good-looking-app-tutorial");
}
