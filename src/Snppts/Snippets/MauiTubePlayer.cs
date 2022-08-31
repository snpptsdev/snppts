namespace Snppts.Snippets;

public class MauiTubePlayer : IAmASnippet
{
    public string Slug => "maui-tube-player";
    public string Title => "Maui Tube Player";
    public GitHubRepoInfo GitHubRepoInfo => new GitHubRepoInfo("naweed/MauiTubePlayer");
    public bool ContainsAndroidSample => true;
    public bool ContainsiOSSample => true;
    public bool ContainsUWPSample => true;
    public bool ContainsmacOSSample => true;
    public Sdk BuiltWith => Sdk.Maui;

    public string Description => "A REAL and BEAUTIFUL Youtube Clone app built using .Net Maui.";

    public IAmAnAuthor AuthorInfo => new NaweedAkram();

    public IEnumerable<Uri> ImageUris => new List<Uri>
    {
        new Uri("https://github.com/naweed/MauiTubePlayer/blob/main/TubePlayerScreenShot.png?raw=true")
    };

    public IList<Category> Categories => new List<Category>
    {
        Category.APPCLONE,
        Category.PLAYBACK,
        Category.SOCIALNETWORK
    };

    public Uri ExternalUri => new Uri("https://github.com/naweed/MauiTubePlayer");
}
