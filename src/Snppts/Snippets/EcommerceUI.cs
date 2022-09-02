namespace Snppts.Snippets;

public class EcommerceUI : IAmASnippet
{
    public string Slug => "EcommerceUI";
    public string Title => "Ecommerce design with MAUI";

    public GitHubRepoInfo GitHubRepoInfo => new GitHubRepoInfo("exendahal/EcommerceMAUI");

    public bool ContainsAndroidSample => true;
    public bool ContainsiOSSample => true;
    public bool ContainsUWPSample => false;
    public Sdk BuiltWith => Sdk.Maui;

    public string Description => "Ecommerce design with NET MAUI (MVVM Pattern)";

    public IAmAnAuthor AuthorInfo => new SantoshDahal();

    public IEnumerable<Uri> ImageUris => new List<Uri>
    {
        new Uri("https://raw.githubusercontent.com/exendahal/EcommerceMAUI/master/Preview/1.png"),
        new Uri("https://raw.githubusercontent.com/exendahal/EcommerceMAUI/master/Preview/2.png"),
        new Uri("https://raw.githubusercontent.com/exendahal/EcommerceMAUI/master/Preview/3.png"),
        new Uri("https://raw.githubusercontent.com/exendahal/EcommerceMAUI/master/Preview/4.png"),
        new Uri("https://raw.githubusercontent.com/exendahal/EcommerceMAUI/master/Preview/5.png"),
        new Uri("https://raw.githubusercontent.com/exendahal/EcommerceMAUI/master/Preview/6.png"),
        new Uri("https://raw.githubusercontent.com/exendahal/EcommerceMAUI/master/Preview/7.png"),
        new Uri("https://raw.githubusercontent.com/exendahal/EcommerceMAUI/master/Preview/8.png"),
        new Uri("https://raw.githubusercontent.com/exendahal/EcommerceMAUI/master/Preview/9.png")
            
    };

    public IList<Category> Categories => new List<Category>
    {
        Category.SHOPPINGCART, Category.TABBARS, Category.DASHBOARD, Category.LISTS
    };

    public Uri ExternalUri => null;
}
