public class XamTranslator : IAmASnippet
{
    public string Slug => "xam-translator";
    public string Title => "Xam Translator";
    public GitHubRepoInfo GitHubRepoInfo => new GitHubRepoInfo("aimore/XamUI");
    public bool ContainsAndroidSample => true;
    public bool ContainsiOSSample => true;
    public bool ContainsUWPSample => false;
    public Sdk BuiltWith => Sdk.XamarinForms;

    public string Description => "This snippet was created to reproduce an Dictionary/Translator App using some Material design components.";

    public IAmAnAuthor AuthorInfo => new AimoreSa();
    
    public Uri ExternalUri => new Uri("https://github.com/aimore/XamUI/tree/master/XFTranslator");

    public IEnumerable<Uri> ImageUris => new List<Uri>
    {
        new Uri("https://i.imgur.com/o2ATjel.png"),
        new Uri("https://i.imgur.com/E7rpRav.png")
    };

    public IList<Category> Categories => new List<Category>
    {
        Category.CARDS
    };
}
