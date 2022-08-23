namespace Snppts.Snippets;

public class BandTracker : IAmASnippet
{
    public string Slug => "band-tracker";
    public string Title => "Band Tracker";
    public GitHubRepoInfo GitHubRepoInfo => new GitHubRepoInfo("michaldivis/band-tracker-app");
    public bool ContainsAndroidSample => true;
    public bool ContainsiOSSample => true;
    public bool ContainsUWPSample => false;

    public string Description => "A simple music artist release and live show tracker app built with .NET MAUI.";

    public IAmAnAuthor AuthorInfo => new MichalDivis();

    public IEnumerable<Uri> ImageUris => new List<Uri>
        {
            new Uri("https://github.com/michaldivis/band-tracker-app/blob/master/screenshots/android_dashboard.png?raw=true"),
            new Uri("https://github.com/michaldivis/band-tracker-app/blob/master/screenshots/android_upcoming_shows.png?raw=true"),
            new Uri("https://github.com/michaldivis/band-tracker-app/blob/master/screenshots/android_artists.png?raw=true"),
            new Uri("https://github.com/michaldivis/band-tracker-app/blob/master/screenshots/android_artist_detail.png?raw=true"),
            new Uri("https://github.com/michaldivis/band-tracker-app/blob/master/screenshots/android_release_detail.png?raw=true"),
        };

    public IList<Category> Categories => new List<Category>
        {
            Category.DASHBOARD,
            Category.CARDS,
            Category.FILTER,
            Category.LISTS,
            Category.PROFILES,
            Category.TABBARS
        };

    public Uri ExternalUri => null;
}