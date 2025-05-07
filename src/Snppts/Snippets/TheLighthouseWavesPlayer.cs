namespace Snppts.Snippets;

public class TheLighthouseWavesPlayer  : IAmASnippet
{
    public string Slug => "the-lighthouse-waves-player";
    public string Title => "TheLighthouseWavesPlayer";
    public string GithubRepoName => "walk-away/TheLighthouseWavesPlayer";
    public Uri ExternalUri => new Uri("https://www.youtube.com/watch?v=wDNoc_bI5LU");
    public bool ContainsAndroidSample => true;
    public bool ContainsiOSSample => false;
    public bool ContainsUWPSample => false;
    public Sdk BuiltWith => Sdk.Maui;

    public string Description => "TheLighthouseWavesPlayer was created to demonstrate the capabilities of the UseMauiCommunityToolkitMediaElement library in the context of an Android video player. The application showcases advanced video playback features including favorites management, screenshots capture, and responsive UI design for both portrait and landscape orientations. It implements proper MVVM architecture with dependency injection, localization support, and efficient video library management.";    
    public GitHubRepoInfo GitHubRepoInfo => new GitHubRepoInfo("walk-away/TheLighthouseWavesPlayer");

    public IAmAnAuthor AuthorInfo => new BohdanHarabadzhyu();

    public IEnumerable<Uri> ImageUris => new List<Uri>
    {
        new Uri("https://raw.githubusercontent.com/walk-away//TheLighthouseWavesPlayer/main/Screenshots/Screenshot(2).png"),
        new Uri("https://raw.githubusercontent.com/walk-away//TheLighthouseWavesPlayer/main/Screenshots/Screenshot(3).png"),
        new Uri("https://raw.githubusercontent.com/walk-away//TheLighthouseWavesPlayer/main/Screenshots/Screenshot(5).png"),
        new Uri("https://raw.githubusercontent.com/walk-away//TheLighthouseWavesPlayer/main/Screenshots/Screenshot(6).png"),
        new Uri("https://raw.githubusercontent.com/walk-away//TheLighthouseWavesPlayer/main/Screenshots/Screenshot(7).png"),
        new Uri("https://raw.githubusercontent.com/walk-away//TheLighthouseWavesPlayer/main/Screenshots/Screenshot(9).png"),
        new Uri("https://raw.githubusercontent.com/walk-away//TheLighthouseWavesPlayer/main/Screenshots/Screenshot(10).png"),
        new Uri("https://raw.githubusercontent.com/walk-away//TheLighthouseWavesPlayer/main/Screenshots/Screenshot(15).png"),
        new Uri("https://raw.githubusercontent.com/walk-away//TheLighthouseWavesPlayer/main/Screenshots/untitled.gif"),
    };

    public IList<Category> Categories => new List<Category>
    {
        Category.PLAYBACK
    };
}