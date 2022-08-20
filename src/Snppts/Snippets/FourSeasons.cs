namespace Snppts.Snippets;

public class FourSeasons : IAmASnippet
{
    public string Slug => "four-seasons";
    public string Title => "Four Seasons";
    public string Description => ".NET MAUI implementation of 4 seasons mobile ui design by Riko Sapto Dimo from Dribbble.com.";
    public GitHubRepoInfo GitHubRepoInfo => new GitHubRepoInfo("RadekVyM/FourSeasons");
    public Uri ExternalUri => null;
    public bool ContainsAndroidSample => true;
    public bool ContainsiOSSample => true;
    public bool ContainsUWPSample => true;
    public Sdk BuiltWith => Sdk.Maui;
    public IAmAnAuthor AuthorInfo => new RadekVymetalik();

    public IEnumerable<Uri> ImageUris => new List<Uri>
    {
        new Uri("https://raw.githubusercontent.com/RadekVyM/FourSeasons/main/images/android.gif"),
        new Uri("https://raw.githubusercontent.com/RadekVyM/FourSeasons/main/images/windows.gif"),
        new Uri("https://raw.githubusercontent.com/RadekVyM/FourSeasons/main/images/all_devices.png")
    };

    public IList<Category> Categories => new List<Category>
    {
        Category.LISTS,
        Category.CARDS,
        Category.NAVIGATIONS,
        Category.CHARTS,
        Category.TABBARS
    };
}

