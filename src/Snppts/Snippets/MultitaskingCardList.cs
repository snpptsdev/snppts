namespace Snppts.Snippets;

public class MultitaskingCardList : IAmASnippet
{
    public string Slug => "An appclone of iOS multitasking app list";

    public string Title => "MultitaskingCardList";

    public string Description => "iOS multitasking app list remake with .NET MAUI";

    public GitHubRepoInfo GitHubRepoInfo => new GitHubRepoInfo("jevonsflash/maui-samples/tree/master/MultitaskingCardList");

    public Uri ExternalUri => new Uri("https://blog.csdn.net/jevonsflash/article/details/130465814");

    public bool ContainsAndroidSample => true;

    public bool ContainsiOSSample => true;

    public bool ContainsUWPSample => false;

    public Sdk BuiltWith => Sdk.Maui;

    public IAmAnAuthor AuthorInfo => new LinXiao();

    public IEnumerable<Uri> ImageUris => new List<Uri>
    {
        new Uri("https://github.com/jevonsflash/maui-samples/blob/master/Assets/a4.gif?raw=true"),
    };

    public IList<Category> Categories => new List<Category>
    {
        Category.APPCLONE,
    };
}
