namespace Snppts.Snippets;

public class HoldAndSpeak : IAmASnippet
{
    public string Slug => "An appclone of wechat hold and speak";

    public string Title => "HoldAndSpeak";

    public string Description => "Wechat hold and speak remake with .NET MAUI";

    public GitHubRepoInfo GitHubRepoInfo => new GitHubRepoInfo("jevonsflash/maui-samples/tree/master/HoldAndSpeak");

    public Uri ExternalUri => new Uri("https://blog.csdn.net/jevonsflash/article/details/130174276");

    public bool ContainsAndroidSample => true;

    public bool ContainsiOSSample => true;

    public bool ContainsUWPSample => false;

    public Sdk BuiltWith => Sdk.Maui;

    public IAmAnAuthor AuthorInfo => new LinXiao();

    public IEnumerable<Uri> ImageUris => new List<Uri>
    {
        new Uri("https://github.com/jevonsflash/maui-samples/blob/master/Assets/a2.gif?raw=true"),
    };

    public IList<Category> Categories => new List<Category>
    {
        Category.APPCLONE,
    };
}
