namespace Snppts.Snippets;

public class IspAppUI : IAmASnippet
{
    public string Slug => "IspApp-ui";
    public string Title => "Broadband Internet Provider/ISP Mobile App design concept";

    public GitHubRepoInfo GitHubRepoInfo => new GitHubRepoInfo("exendahal/Vianet");

    public bool ContainsAndroidSample => true;
    public bool ContainsiOSSample => true;
    public bool ContainsUWPSample => false;
    public Sdk BuiltWith => Sdk.XamarinForms;

    public string Description => "Design concept for Broadband Internet Provider or ISP. in Xamarin.Forms.";

    public IAmAnAuthor AuthorInfo => new SantoshDahal();

    public IEnumerable<Uri> ImageUris => new List<Uri>
    {
        new Uri("https://raw.githubusercontent.com/exendahal/Vianet/master/Screenshot/1.png"),
        new Uri("https://raw.githubusercontent.com/exendahal/Vianet/master/Screenshot/2.png"),
        new Uri("https://raw.githubusercontent.com/exendahal/Vianet/master/Screenshot/3.png"),
        new Uri("https://raw.githubusercontent.com/exendahal/Vianet/master/Screenshot/4.png"),
        new Uri("https://raw.githubusercontent.com/exendahal/Vianet/master/Screenshot/5.png"),
        new Uri("https://raw.githubusercontent.com/exendahal/Vianet/master/Screenshot/6.png"),
        new Uri("https://raw.githubusercontent.com/exendahal/Vianet/master/Screenshot/7.png"),
        new Uri("https://raw.githubusercontent.com/exendahal/Vianet/master/Screenshot/8.png"),       
    };

    public IList<Category> Categories => new List<Category>
    {
        Category.LOGIN, Category.TABBARS, Category.WIDGETS, Category.LISTS, Category.DASHBOARD
    };

    public Uri ExternalUri => null;
}
