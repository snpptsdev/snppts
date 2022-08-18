namespace Snppts.Snippets;

public class DashboardDrawer : IAmASnippet
{
    public string Slug => "dashboard-drawer";

    public string Title => "Dashboard Drawer";

    public string Description => "Dashboard with drawer";

    public GitHubRepoInfo GitHubRepoInfo => new GitHubRepoInfo("AlexandreSanlim/XamarinUI.DashboardDrawer");

    public Uri ExternalUri => null;

    public bool ContainsAndroidSample => true;

    public bool ContainsiOSSample => true;

    public bool ContainsUWPSample => false;
    public Sdk BuiltWith => Sdk.XamarinForms;

    public IAmAnAuthor AuthorInfo => new AlexandreSanlim();

    public IEnumerable<Uri> ImageUris => new List<Uri>
    {
        new Uri("https://github.com/alexandresanlim/XamarinUI.Dashboard/raw/master/XamarinUI.Dashboard/XamarinUI.Dashboard/Src/Img/Screen/android.gif?raw=true"),
        new Uri("https://github.com/alexandresanlim/XamarinUI.Dashboard/raw/master/XamarinUI.Dashboard/XamarinUI.Dashboard/Src/Img/Screen/ios.png?raw=true")
    };

    public IList<Category> Categories => new List<Category>
    {
         Category.DASHBOARD,
         Category.CARDS
    };
}
