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
        new Uri("https://camo.githubusercontent.com/29e5cb48156b3dce2b5cd9add27a6deaa90f4bed4557dd77d9408ab2c881de17/68747470733a2f2f692e696d6775722e636f6d2f5a6d5658356f532e706e67"),
        new Uri("https://camo.githubusercontent.com/4812f8a75d90486ddbaedff2c0ca37ada7abe8c0cd6461696e65a1d912cf9263/68747470733a2f2f692e696d6775722e636f6d2f645844673978462e706e67"),
        new Uri("https://camo.githubusercontent.com/80ae6e61a98e804c89115a605859d6e5294568e6c2b34dcb91767759630e0417/68747470733a2f2f692e696d6775722e636f6d2f5969696b564c502e706e67"),
        new Uri("https://camo.githubusercontent.com/5f2ca743283eabd1ab539924d19f294a2f7bea9b78f5f5f348e2eb1612054328/68747470733a2f2f692e696d6775722e636f6d2f4d38536134654e2e706e67")
    };

    public IList<Category> Categories => new List<Category>
    {
        Category.NAVIGATIONS, Category.DASHBOARD
    };
}
