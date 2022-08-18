namespace Snppts.Snippets;

public class SkiaGaugeChart : IAmASnippet
{
    public string Slug => "skia-gauge-chart";
    public string Title => "Skia Gauge Chart";

    public GitHubRepoInfo GitHubRepoInfo => new GitHubRepoInfo("felipebaltazar/CustomCharts");

    public bool ContainsAndroidSample => true;
    public bool ContainsiOSSample => true;
    public bool ContainsUWPSample => false;
    public Sdk BuiltWith => Sdk.XamarinForms;

    public string Description => "Simple gauge chart created with SkiaSharp for Xamarin.Forms";

    public IAmAnAuthor AuthorInfo => new FelipeBaltazar();

    public IEnumerable<Uri> ImageUris => new List<Uri>
    {
        new Uri("https://user-images.githubusercontent.com/19656249/68064111-40c02780-fcf6-11e9-85c8-0fdd45caf3eb.gif"),
        new Uri("https://miro.medium.com/max/1011/1*noyssgwjdBPHXnqu7IAtqw.gif"),
        new Uri("https://miro.medium.com/max/238/1*df_vGdlRXUmIP3UumAi_hg.png")
    };

    public IList<Category> Categories => new List<Category>
    {
        Category.CHARTS,
        Category.DASHBOARD,
        Category.CARDS,
        Category.WIDGETS
    };

    public Uri ExternalUri => new Uri("https://medium.com/@felipedasilvabaltazar/xamarin-controles-personalizados-com-skiasharp-13ffcfbaa6b6");
}
