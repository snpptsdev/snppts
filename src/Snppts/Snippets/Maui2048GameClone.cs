namespace Snppts.Snippets;

public class Maui2048GameClone : IAmASnippet
{
    public string Slug => "maui-2048-game-clone";
    public string Title => "Maui 2048 Game Clone";
    public GitHubRepoInfo GitHubRepoInfo => new GitHubRepoInfo("codeanees/2048Maui");
    public bool ContainsAndroidSample => true;
    public bool ContainsiOSSample => true;
    public bool ContainsUWPSample => false;
    public bool ContainsmacOSSample => true;
    public Sdk BuiltWith => Sdk.Maui;

    public string Description => "Cloned version of classic 2048 game built using .NET Maui.";

    public IAmAnAuthor AuthorInfo => new Aneesdeen();

    public IEnumerable<Uri> ImageUris => new List<Uri>
    {
        new Uri("https://raw.githubusercontent.com/codeanees/2048Maui/main/Images/001.jpg"),
        new Uri("https://raw.githubusercontent.com/codeanees/2048Maui/main/Images/002.jpg"),
        new Uri("https://raw.githubusercontent.com/codeanees/2048Maui/4863492e7d9660c3fd9bdffe90aa26eb6d00e20f/Images/maui2048_play.gif"),
    };

    public IList<Category> Categories => new List<Category>
    {
        Category.APPCLONE
    };

    public Uri ExternalUri => null;
}
