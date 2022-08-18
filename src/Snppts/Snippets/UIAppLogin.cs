namespace Snppts.Snippets;

public class UIAppLogin : IAmASnippet
{
    public string Slug => "ui-app-login";
    public string Title => "UI App Login";

    public GitHubRepoInfo GitHubRepoInfo => new GitHubRepoInfo("CrossGeeks/Xamarin.Forms.UI");

    public bool ContainsAndroidSample => true;
    public bool ContainsiOSSample => true;
    public bool ContainsUWPSample => false;
    public Sdk BuiltWith => Sdk.XamarinForms;

    public string Description => "Simple Login UI. NOTE: Check I'm using an effect for line border entry, the implementation is in the Android/iOS project.";

    public IAmAnAuthor AuthorInfo => new CharlinAgramonte();

    public IEnumerable<Uri> ImageUris => new List<Uri>
    {
        new Uri("https://raw.githubusercontent.com/snpptsdev/MigratedImages/master/63/110.jpg")
    };

    public IList<Category> Categories => new List<Category>
    {
        Category.LOGIN
    };

    public Uri ExternalUri => null;
}
