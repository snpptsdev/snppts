public class BottomAppBar : IAmASnippet
{
    public string Slug => "bottomappbar-material";
    public string Title => "BottomAppBar Material";
    public GitHubRepoInfo GitHubRepoInfo => new GitHubRepoInfo("aimore/XamUI");
    public bool ContainsAndroidSample => true;
    public bool ContainsiOSSample => true;
    public bool ContainsUWPSample => false;
    public Sdk BuiltWith => Sdk.XamarinForms;

    public string Description => "This snippet was created to reproduce the Material BottomAppBar, originally from android using custom renderers and Xamarin.Forms Visual.Material.";

    public IAmAnAuthor AuthorInfo => new AimoreSa();

    public Uri ExternalUri => new Uri("https://github.com/aimore/XamUI/tree/master/XamFood");

    public IEnumerable<Uri> ImageUris => new List<Uri>
    {
        new Uri("https://camo.githubusercontent.com/46611cb54cec1ef787e32c27248fa1ba6026f93990f64210cfa15696c3c49923/68747470733a2f2f692e696d6775722e636f6d2f5969696b564c502e706e67"),
        new Uri("https://camo.githubusercontent.com/4812f8a75d90486ddbaedff2c0ca37ada7abe8c0cd6461696e65a1d912cf9263/68747470733a2f2f692e696d6775722e636f6d2f645844673978462e706e67")
    };

    public IList<Category> Categories => new List<Category>
    {
        Category.NAVIGATIONS, Category.DASHBOARD
    };
}
