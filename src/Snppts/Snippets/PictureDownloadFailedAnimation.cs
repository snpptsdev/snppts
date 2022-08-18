namespace Snppts.Snippets;

public class PictureDownloadFailedAnimation : IAmASnippet
{
    public string Slug => "picture-download-failed-animation";
    public string Title => "Picture Download Failed Animation";
    public GitHubRepoInfo GitHubRepoInfo => new GitHubRepoInfo("DanielCauser/XamarinFFImageLoadingAndLottie");
    public bool ContainsAndroidSample => true;
    public bool ContainsiOSSample => true;
    public bool ContainsUWPSample => false;
    public Sdk BuiltWith => Sdk.XamarinForms;

    public string Description => "This is a sample uses Lottie lib to bring awesome animations to FFImageLoading images lib for Loading indicators and faulted download!! ListView that will download pictures from a URL. While downloading the pictures it will display a loading animation. If download succeeds, it will display and cache the image (FFIMageLoader). If it fails, it will display a failed download animation.";

    public IAmAnAuthor AuthorInfo => new DanielJohnCauser();

    public IEnumerable<Uri> ImageUris => new List<Uri>
    {
        new Uri("https://raw.githubusercontent.com/snpptsdev/MigratedImages/master/140/168.jpg"),
        new Uri("https://raw.githubusercontent.com/snpptsdev/MigratedImages/master/140/169.jpg"),
        new Uri("https://raw.githubusercontent.com/snpptsdev/MigratedImages/master/140/170.jpg")
    };

    public IList<Category> Categories => new List<Category>
    {
        Category.LISTS, Category.PHOTOS
    };

    public Uri ExternalUri => null;
}
