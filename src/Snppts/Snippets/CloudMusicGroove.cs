namespace Snppts.Snippets;

public class CloudMusicGroove : IAmASnippet
{
    public string Slug => "An appclone of EasyNet CouldMusic app";

    public string Title => "CloudMusicGroove";

    public string Description => "EasyNet CouldMusic app remake with .NET MAUI";

    public GitHubRepoInfo GitHubRepoInfo => new GitHubRepoInfo("jevonsflash/maui-samples/tree/master/CloudMusicGroove");

    public Uri ExternalUri => new Uri("https://blog.csdn.net/jevonsflash/article/details/130353772");

    public bool ContainsAndroidSample => true;

    public bool ContainsiOSSample => true;

    public bool ContainsUWPSample => false;

    public Sdk BuiltWith => Sdk.Maui;

    public IAmAnAuthor AuthorInfo => new LinXiao();

    public IEnumerable<Uri> ImageUris => new List<Uri>
    {
        new Uri("https://github.com/jevonsflash/maui-samples/blob/master/Assets/a0.gif?raw=true"),
    };

    public IList<Category> Categories => new List<Category>
    {
        Category.APPCLONE,
    };
}
