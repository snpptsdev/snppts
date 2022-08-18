namespace Snppts.Snippets;

public class WhatsAppUI : IAmASnippet
{
    public string Slug => "whatsapp-ui";
    public string Title => "WhatsApp UI Clone";

    public GitHubRepoInfo GitHubRepoInfo => new GitHubRepoInfo("egbakou/WhatsAppUI");

    public bool ContainsAndroidSample => true;
    public bool ContainsiOSSample => true;
    public bool ContainsUWPSample => false;
    public Sdk BuiltWith => Sdk.XamarinForms;

    public string Description => "WhatsApp UI Clone in Xamarin.Forms.";

    public IAmAnAuthor AuthorInfo => new KodjoLaurentEgbakou();

    public IEnumerable<Uri> ImageUris => new List<Uri>
    {
        new Uri("https://raw.githubusercontent.com/egbakou/WhatsAppUI/master/WhatsAppUI/screenshots/Screenshot_20190504-153320.png"),
        new Uri("https://raw.githubusercontent.com/egbakou/WhatsAppUI/master/WhatsAppUI/screenshots/Screenshot_20190504-153321.png"),
        new Uri("https://raw.githubusercontent.com/egbakou/WhatsAppUI/master/WhatsAppUI/screenshots/Screenshot_20190504-153403.png"),
        new Uri("https://raw.githubusercontent.com/egbakou/WhatsAppUI/master/WhatsAppUI/screenshots/Screenshot_20190504-153435.png"),
        new Uri("https://raw.githubusercontent.com/egbakou/WhatsAppUI/master/WhatsAppUI/screenshots/Screenshot_20190504-153734.png"),
        new Uri("https://raw.githubusercontent.com/egbakou/WhatsAppUI/master/WhatsAppUI/screenshots/Screenshot_20190504-153830.png")
    };

    public IList<Category> Categories => new List<Category>
    {
        Category.PHOTOS, Category.MESSAGING, Category.FRIENDS, Category.LISTS
    };

    public Uri ExternalUri => new Uri("https://lioncoding.com/2019/05/08/2019-05-08-whatsapp-ui-dans-xamarin-forms-partie-1/");
}
