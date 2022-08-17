namespace Snppts.Snippets;

public class AddCreditCard : IAmASnippet
{
    public string Slug => "addcreditcard";

    public string Title => "Add Credit Card";

    public string Description => "Add a credit card from user";

    public GitHubRepoInfo GitHubRepoInfo => new GitHubRepoInfo("alexandresanlim/XamarinUI.AddCreditCard");

    public Uri ExternalUri => null;

    public bool ContainsAndroidSample => true;

    public bool ContainsiOSSample => true;

    public bool ContainsUWPSample => false;

    public Sdk BuiltWith => Sdk.XamarinForms;

    public IAmAnAuthor AuthorInfo => new AlexandreSanlim();

    public IEnumerable<Uri> ImageUris => new List<Uri>
    {
        new Uri("https://raw.githubusercontent.com/alexandresanlim/XamarinUI.AddCreditCard/master/XamarinUI.AddCreditCard/XamarinUI.AddCreditCard/src/screenshot/android.gif"),
        new Uri("https://raw.githubusercontent.com/alexandresanlim/XamarinUI.AddCreditCard/master/XamarinUI.AddCreditCard/XamarinUI.AddCreditCard/src/screenshot/iosfront.png"),
        new Uri("https://raw.githubusercontent.com/alexandresanlim/XamarinUI.AddCreditCard/master/XamarinUI.AddCreditCard/XamarinUI.AddCreditCard/src/screenshot/iosback.png")
    };

    public IList<Category> Categories => new List<Category>
    {
        Category.STORES,
        Category.SHOPPINGCART
    };
}
