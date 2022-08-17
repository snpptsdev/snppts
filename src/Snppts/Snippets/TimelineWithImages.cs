namespace Snppts.Snippets;

public class TimelineWithImages : IAmASnippet
{
    public string Slug => "timeline-with-images";
    public string Title => "Timeline With Images";

    public GitHubRepoInfo GitHubRepoInfo => new GitHubRepoInfo("egbakou/Timeline");

    public bool ContainsAndroidSample => true;
    public bool ContainsiOSSample => true;
    public bool ContainsUWPSample => false;
    public Sdk BuiltWith => Sdk.XamarinForms;

    public string Description => "Timeline with images in Xamarin.Forms.";

    public IAmAnAuthor AuthorInfo => new KodjoLaurentEgbakou();

    public IEnumerable<Uri> ImageUris => new List<Uri>
    {
        new Uri("https://raw.githubusercontent.com/egbakou/Timeline/master/Timeline/screenshots/Screenshot_1.png"),
        new Uri("https://raw.githubusercontent.com/egbakou/Timeline/master/Timeline/screenshots/Screenshot_2.png"),
        new Uri("https://raw.githubusercontent.com/egbakou/Timeline/master/Timeline/screenshots/Screenshot_3.png")
    };

    public IList<Category> Categories => new List<Category>
    {
        Category.PHOTOS, Category.TIMELINE, Category.LISTS
    };

    public Uri ExternalUri => new Uri("https://lioncoding.com/2019/04/08/2019-04-08-UI-Concevoir-un-Timeline-dans-Xamarin-Forms/");
}
