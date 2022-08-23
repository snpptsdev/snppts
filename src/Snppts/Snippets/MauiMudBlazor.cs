namespace Snppts.Snippets;

public class MauiMudBlazor : IAmASnippet
{
    public string Slug => "MauiBlazorWeb";
    public string Title => "Maui Mud Blazor";

    public GitHubRepoInfo GitHubRepoInfo => new GitHubRepoInfo("kevmoens/MauiBlazorWeb");

    public bool ContainsAndroidSample => true;
    public bool ContainsiOSSample => true;
    public bool ContainsUWPSample => false;
    public Sdk BuiltWith => Sdk.Maui;

    public string Description => "";

    public IAmAnAuthor AuthorInfo => new KevinMoens();

    public IEnumerable<Uri> ImageUris => new List<Uri>
    {
        new Uri("https://raw.githubusercontent.com/kevmoens/MauiBlazorWeb/main/example1.png")
    };

    public IList<Category> Categories => new List<Category>
    {
        Category.DATAGRID, Category.SIDEBARS
    };

    public Uri ExternalUri => null;
}
