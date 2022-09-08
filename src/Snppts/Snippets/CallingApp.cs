namespace Snppts.Snippets;

public class CallingApp : IAmASnippet
{
    public string Slug => "calling-app";
    public string Title => "Calling App";
    public string Description => ".NET MAUI implementation of majority wallet & calling design by Hampus Öhman from Dribbble.com.";
    public GitHubRepoInfo GitHubRepoInfo => new GitHubRepoInfo("RadekVyM/Calling-App");
    public Uri ExternalUri => null;
    public bool ContainsAndroidSample => true;
    public bool ContainsiOSSample => true;
    public bool ContainsUWPSample => true;
    public Sdk BuiltWith => Sdk.Maui;
    public IAmAnAuthor AuthorInfo => new RadekVymetalik();

    public IEnumerable<Uri> ImageUris => new List<Uri>
    {
        new Uri("https://raw.githubusercontent.com/RadekVyM/Calling-App/main/Images/android_callingapp_call.gif"),
        new Uri("https://raw.githubusercontent.com/RadekVyM/Calling-App/main/Images/ios_callingapp_home.png"),
        new Uri("https://raw.githubusercontent.com/RadekVyM/Calling-App/main/Images/ios_callingapp_calling.png"),
        new Uri("https://raw.githubusercontent.com/RadekVyM/Calling-App/main/Images/ios_callingapp_call.png"),
        new Uri("https://raw.githubusercontent.com/RadekVyM/Calling-App/main/Images/windows_callingapp.gif"),
    };

    public IList<Category> Categories => new List<Category>
    {
        Category.LISTS,
        Category.CARDS,
        Category.NAVIGATIONS
    };
}
