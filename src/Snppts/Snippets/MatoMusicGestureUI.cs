namespace Snppts.Snippets;

public class MatoMusicGestureUI : IAmASnippet
{
    public string Slug => "mato-music-gesture-ui";

    public string Title => "MatoMusic-GestureUI";

    public string Description => "a music player with gesture UI";

    public GitHubRepoInfo GitHubRepoInfo => new GitHubRepoInfo("jevonsflash/maui-samples/tree/master/MatoMusic-GestureUI");

    public Uri ExternalUri => new Uri("https://blog.csdn.net/jevonsflash/article/details/130031596");

    public bool ContainsAndroidSample => true;

    public bool ContainsiOSSample => true;

    public bool ContainsUWPSample => false;

    public Sdk BuiltWith => Sdk.Maui;

    public IAmAnAuthor AuthorInfo => new LinXiao();

    public IEnumerable<Uri> ImageUris => new List<Uri>
    {
        new Uri("https://github.com/jevonsflash/maui-samples/blob/master/Assets/a1.gif?raw=true"),
    };

    public IList<Category> Categories => new List<Category>
    {
        Category.PLAYBACK,
    };
}
