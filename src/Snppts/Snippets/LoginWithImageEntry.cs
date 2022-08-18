namespace Snppts.Snippets;

public class LoginWithImageEntry : IAmASnippet
{
    public string Slug => "login-with-imageentry";
    public string Title => "Login with ImageEntry";
    public GitHubRepoInfo GitHubRepoInfo => new GitHubRepoInfo("CrossGeeks/Xamarin.Forms.UI");
    public bool ContainsAndroidSample => true;
    public bool ContainsiOSSample => true;
    public bool ContainsUWPSample => false;

    public Sdk BuiltWith => Sdk.XamarinForms;

    public string Description => "Login UI. NOTE: Check I'm using a custom renderer, the implementation is in the Android/iOS project.";

    public IAmAnAuthor AuthorInfo => new CharlinAgramonte();

    public IEnumerable<Uri> ImageUris => new List<Uri>
    {
        new Uri("https://raw.githubusercontent.com/snpptsdev/MigratedImages/master/68/114.jpg")
    };

    public IList<Category> Categories => new List<Category>
    {
        Category.LOGIN
    };

    public Uri ExternalUri => new Uri("https://xamgirl.com/image-entry-in-xamarin-forms");
}
