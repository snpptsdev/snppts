namespace Snppts.Snippets;

public class SpotifyClone : IAmASnippet
{
    public string Slug => "spotify-clone";
    public string Title => "Spotify Clone";

    public GitHubRepoInfo GitHubRepoInfo => new GitHubRepoInfo("sthewissen/KickassUI.Spotify");

    public bool ContainsAndroidSample => true;
    public bool ContainsiOSSample => true;
    public bool ContainsUWPSample => false;
    public Sdk BuiltWith => Sdk.XamarinForms;

    public string Description => "A Xamarin.Forms version of the Spotify app to prove you can create goodlooking UI with Xamarin.Forms as talked about in my blogpost.";

    public IAmAnAuthor AuthorInfo => new StevenThewissen();

    public IEnumerable<Uri> ImageUris => new List<Uri>
    {
        new Uri("https://raw.githubusercontent.com/sthewissen/KickassUI.Spotify/master/images/spotify1.jpg"),
        new Uri("https://raw.githubusercontent.com/sthewissen/KickassUI.Spotify/master/images/spotify2.jpg"),
        new Uri("https://raw.githubusercontent.com/sthewissen/KickassUI.Spotify/master/images/spotify3.jpg"),
        new Uri("https://raw.githubusercontent.com/sthewissen/KickassUI.Spotify/master/images/spotify4.jpg")
    };

    public IList<Category> Categories => new List<Category>
    {
        Category.PLAYBACK, Category.LISTS, Category.DASHBOARD, Category.APPCLONE
    };

    public Uri ExternalUri => new Uri("https://www.thewissen.io/xamarin-forms-ui-spotify");
}
