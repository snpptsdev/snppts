namespace Snppts.Snippets;

public class PlacesApp : IAmASnippet
{
    public string Slug => "places-app-ui";
    public string Title => "Places App UI";
    public GitHubRepoInfo GitHubRepoInfo => new GitHubRepoInfo("valentineg8/PlacesApp");
    public bool ContainsAndroidSample => true;
    public bool ContainsiOSSample => true;
    public bool ContainsUWPSample => false;
    public Sdk BuiltWith => Sdk.XamarinForms;

    public string Description => "A Xamarin.Forms Places App Ui.";

    public IAmAnAuthor AuthorInfo => new LorenzoAraujo();

    public IEnumerable<Uri> ImageUris => new List<Uri>
    {
        new Uri("https://raw.githubusercontent.com/valentineg8/PlacesApp/master/images/ios.gif?raw=true"),
        new Uri("https://raw.githubusercontent.com/valentineg8/PlacesApp/master/images/android.gif?raw=true")
    };

    public IList<Category> Categories => new List<Category>
    {
        Category.LISTS
    };

    public Uri ExternalUri => null;
}
