namespace Snppts.Snippets;

public class RunkeeperClone : IAmASnippet
{
    public string Slug => "runkeeper-clone";
    public string Title => "Runkeeper Clone";
    public GitHubRepoInfo GitHubRepoInfo => new GitHubRepoInfo("sthewissen/KickassUI.Runkeeper");
    public bool ContainsAndroidSample => true;
    public bool ContainsiOSSample => true;
    public bool ContainsUWPSample => false;
    public Sdk BuiltWith => Sdk.XamarinForms;

    public string Description => "A Xamarin.Forms version of the Runkeeper app to prove you can create goodlooking UI with Xamarin.Forms as talked about in my blogpost.";

    public IAmAnAuthor AuthorInfo => new StevenThewissen();

    public IEnumerable<Uri> ImageUris => new List<Uri>
    {
        new Uri("https://raw.githubusercontent.com/snpptsdev/MigratedImages/master/49/126.jpg"),
        new Uri("https://raw.githubusercontent.com/snpptsdev/MigratedImages/master/49/127.jpg"),
        new Uri("https://raw.githubusercontent.com/snpptsdev/MigratedImages/master/49/128.jpg"),
        new Uri("https://raw.githubusercontent.com/snpptsdev/MigratedImages/master/49/129.jpg")
    };

    public IList<Category> Categories => new List<Category>
    {
        Category.MAPS, Category.NAVIGATIONS, Category.DASHBOARD, Category.APPCLONE
    };

    public Uri ExternalUri => new Uri("https://www.thewissen.io/xamarin-forms-ui-runkeeper");
}
