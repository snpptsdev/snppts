namespace Snppts.Snippets;

public class Coverflow : IAmASnippet
{
    public string Slug => "coverflow";

    public string Title => "Coverflow";

    public string Description => "An Apple Coverflow view remake with .NET MAUI";

    public GitHubRepoInfo GitHubRepoInfo => new GitHubRepoInfo("jevonsflash/maui-samples/tree/master/Coverflow");

    public Uri ExternalUri => new Uri("https://blog.csdn.net/jevonsflash/article/details/130798337");

    public bool ContainsAndroidSample => true;

    public bool ContainsiOSSample => true;

    public bool ContainsUWPSample => false;

    public Sdk BuiltWith => Sdk.Maui;

    public IAmAnAuthor AuthorInfo => new LinXiao();

    public IEnumerable<Uri> ImageUris => new List<Uri>
    {
        new Uri("https://github.com/jevonsflash/maui-samples/blob/master/Assets/a3.gif?raw=true"),
    };

    public IList<Category> Categories => new List<Category>
    {
        Category.APPCLONE,
    };
}
