namespace Snppts.Snippets;

public class BreadcrumbControl : IAmASnippet
{
    public string Slug => "breadcrumb-control";
    public string Title => "Breadcrumb control";
    public GitHubRepoInfo GitHubRepoInfo => new GitHubRepoInfo("IeuanWalker/Maui.Breadcrumb");
    public bool ContainsAndroidSample => true;
    public bool ContainsiOSSample => true;
    public bool ContainsUWPSample => false;
    public Sdk BuiltWith => Sdk.Maui;

    public string Description => "This is a breadcrumb navigation control that is completely automatic and uses the Navigation stack to get the page titles to generate the breadcrumbs.";

    public IAmAnAuthor AuthorInfo => new IeuanWalker();

    public IEnumerable<Uri> ImageUris => new List<Uri>
    {
        new Uri("https://raw.githubusercontent.com/IeuanWalker/Maui.Breadcrumb/master/ProdExample.gif"),
        new Uri("https://raw.githubusercontent.com/IeuanWalker/Maui.Breadcrumb/master/Example.gif")
    };

    public IList<Category> Categories => new List<Category>
    {
        Category.NAVIGATIONS, Category.SIDEBARS
    };


    public Uri ExternalUri => null;
}
