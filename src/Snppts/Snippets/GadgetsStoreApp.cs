namespace Snppts.Snippets;

public class GadgetsStoreApp : IAmASnippet
{
    public string Slug => "gadgets-store-app";
    public string Title => "Gadgets Store App";
    public string Description => ".NET MAUI implementation of Gadgets Store App design by Sajon from Dribbble.com.";
    public GitHubRepoInfo GitHubRepoInfo => new GitHubRepoInfo("RadekVyM/Gadgets-Store-App");
    public Uri ExternalUri => null;
    public bool ContainsAndroidSample => true;
    public bool ContainsiOSSample => true;
    public bool ContainsUWPSample => false;
    public Sdk BuiltWith => Sdk.Maui;
    public IAmAnAuthor AuthorInfo => new RadekVymetalik();

    public IEnumerable<Uri> ImageUris => new List<Uri>
    {
        new Uri("https://raw.githubusercontent.com/RadekVyM/Gadgets-Store-App/main/samples/gadget_store_menu.gif"),
        new Uri("https://raw.githubusercontent.com/RadekVyM/Gadgets-Store-App/main/samples/gadget_store_home.gif"),
        new Uri("https://raw.githubusercontent.com/RadekVyM/Gadgets-Store-App/main/samples/gadget_store_detail.gif"),
        new Uri("https://raw.githubusercontent.com/RadekVyM/Gadgets-Store-App/main/samples/iphone_gadget_store_home.png"),
        new Uri("https://raw.githubusercontent.com/RadekVyM/Gadgets-Store-App/main/samples/iphone_gadget_store_menu.png"),
        new Uri("https://raw.githubusercontent.com/RadekVyM/Gadgets-Store-App/main/samples/iphone_gadget_store_detail.png"),
    };

    public IList<Category> Categories => new List<Category>
    {
        Category.LISTS,
        Category.CARDS, 
        Category.NAVIGATIONS,
        Category.PRODUCTS
    };
}
