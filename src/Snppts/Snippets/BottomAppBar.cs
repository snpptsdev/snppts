public class PinBasedLogin : IAmASnippet
{
    public string Slug => "bottomappbar-material";
    public string Title => "BottomAppBar Material";
    public string GithubRepoName => "aimore/XamUI";
    public bool ContainsAndroidSample => true;
    public bool ContainsiOSSample => true;
    public bool ContainsUWPSample => false;

    public string Description => "This snippet was created to reproduce the Material BottomAppBar, originally from android using custom renderers and Xamarin.Forms Visual.Material.";

    public IAmAnAuthor AuthorInfo => new AimoreSa();
    
    public Uri ExternalUri => new Uri("https://github.com/aimore/XamUI/tree/master/XamFood");

    public IEnumerable<Uri> ImageUris => new List<Uri>
    {
        new Uri("https://i.imgur.com/Q8cuoVf.png"),
        new Uri("https://i.imgur.com/dXDg9xF.png")
    };

    public IList<Category> Categories => new List<Category>
    {
        Category.NAVIGATIONS, Category.DASHBOARD
    };
}
