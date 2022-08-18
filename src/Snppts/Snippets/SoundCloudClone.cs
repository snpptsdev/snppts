namespace Snppts.Snippets;

public class SoundCloudClone : IAmASnippet
{
    public string Slug => "soundcloud-clone";
    public string Title => "SoundCloud Clone";
    public string Description => "A clone of the SoundCloud app made with Xamarin.Forms. At moment this app contains the albums, streamings, search and library screens, both in light and dark mode.";

    public GitHubRepoInfo GitHubRepoInfo => new GitHubRepoInfo("ionixjunior/SoundCloudClone");

    public Uri ExternalUri => new Uri("https://www.youtube.com/playlist?list=PL6M6J_6V_um8IzRN4lgRUEWrPWC6iQfiq");
    public bool ContainsAndroidSample => true;
    public bool ContainsiOSSample => true;
    public bool ContainsUWPSample => false;
    public Sdk BuiltWith => Sdk.XamarinForms;

    public IAmAnAuthor AuthorInfo => new IoneSouzaJunior();

    public IEnumerable<Uri> ImageUris => new List<Uri>
    {
        new Uri("https://raw.githubusercontent.com/ionixjunior/SoundCloudClone/master/art/android_home_1_light.png"),
        new Uri("https://raw.githubusercontent.com/ionixjunior/SoundCloudClone/master/art/android_home_1_dark.png"),
        new Uri("https://raw.githubusercontent.com/ionixjunior/SoundCloudClone/master/art/android_stream_1_light.png"),
        new Uri("https://raw.githubusercontent.com/ionixjunior/SoundCloudClone/master/art/android_stream_1_dark.png"),
        new Uri("https://raw.githubusercontent.com/ionixjunior/SoundCloudClone/master/art/android_search_1_light.png"),
        new Uri("https://raw.githubusercontent.com/ionixjunior/SoundCloudClone/master/art/android_search_1_dark.png"),
        new Uri("https://raw.githubusercontent.com/ionixjunior/SoundCloudClone/master/art/android_search_2_light.png"),
        new Uri("https://raw.githubusercontent.com/ionixjunior/SoundCloudClone/master/art/android_search_2_dark.png"),
        new Uri("https://raw.githubusercontent.com/ionixjunior/SoundCloudClone/master/art/android_search_3_light.png"),
        new Uri("https://raw.githubusercontent.com/ionixjunior/SoundCloudClone/master/art/android_search_3_dark.png"),
        new Uri("https://raw.githubusercontent.com/ionixjunior/SoundCloudClone/master/art/android_library_1_light.png"),
        new Uri("https://raw.githubusercontent.com/ionixjunior/SoundCloudClone/master/art/android_library_1_dark.png"),
        new Uri("https://raw.githubusercontent.com/ionixjunior/SoundCloudClone/master/art/android_library_2_light.png"),
        new Uri("https://raw.githubusercontent.com/ionixjunior/SoundCloudClone/master/art/android_library_2_dark.png"),
        new Uri("https://raw.githubusercontent.com/ionixjunior/SoundCloudClone/master/art/ios_home_1_light.png"),
        new Uri("https://raw.githubusercontent.com/ionixjunior/SoundCloudClone/master/art/ios_home_1_dark.png"),
        new Uri("https://raw.githubusercontent.com/ionixjunior/SoundCloudClone/master/art/ios_stream_1_light.png"),
        new Uri("https://raw.githubusercontent.com/ionixjunior/SoundCloudClone/master/art/ios_stream_1_dark.png"),
        new Uri("https://raw.githubusercontent.com/ionixjunior/SoundCloudClone/master/art/ios_search_1_light.png"),
        new Uri("https://raw.githubusercontent.com/ionixjunior/SoundCloudClone/master/art/ios_search_1_dark.png"),
        new Uri("https://raw.githubusercontent.com/ionixjunior/SoundCloudClone/master/art/ios_search_2_light.png"),
        new Uri("https://raw.githubusercontent.com/ionixjunior/SoundCloudClone/master/art/ios_search_2_dark.png"),
        new Uri("https://raw.githubusercontent.com/ionixjunior/SoundCloudClone/master/art/ios_search_3_light.png"),
        new Uri("https://raw.githubusercontent.com/ionixjunior/SoundCloudClone/master/art/ios_search_3_dark.png"),
        new Uri("https://raw.githubusercontent.com/ionixjunior/SoundCloudClone/master/art/ios_library_1_light.png"),
        new Uri("https://raw.githubusercontent.com/ionixjunior/SoundCloudClone/master/art/ios_library_1_dark.png"),
        new Uri("https://raw.githubusercontent.com/ionixjunior/SoundCloudClone/master/art/ios_library_2_light.png"),
        new Uri("https://raw.githubusercontent.com/ionixjunior/SoundCloudClone/master/art/ios_library_2_dark.png")
    };

    public IList<Category> Categories => new List<Category>
    {
        Category.APPCLONE,
        Category.LISTS,
        Category.TABBARS,
        Category.ACTIVITYFEEDS,
        Category.SEARCH
    };
}
