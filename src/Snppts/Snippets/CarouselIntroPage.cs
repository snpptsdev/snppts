namespace Snppts.Snippets;

public class CarouselIntroPage : IAmASnippet
{
    public string Slug => "carousel-intro-page";
    public string Title => "Carousel Intro Page";

    public GitHubRepoInfo GitHubRepoInfo => new GitHubRepoInfo("LucioMSP/Xamarin.Forms.Examples/tree/master/CarouselIntroPage");

    public bool ContainsAndroidSample => true;
    public bool ContainsiOSSample => true;
    public bool ContainsUWPSample => false;
    public Sdk BuiltWith => Sdk.XamarinForms;

    public string Description => "Simple example of an introductory page in Xamarin.Forms.";

    public IAmAnAuthor AuthorInfo => new VicenteGuzman();

    public IEnumerable<Uri> ImageUris => new List<Uri>
    {
        new Uri("https://raw.githubusercontent.com/LucioMSP/Xamarin.Forms.Examples/master/CarouselIntroPage/ScreenShots/CarouselIntroPage.gif"),
        new Uri("https://raw.githubusercontent.com/LucioMSP/Xamarin.Forms.Examples/master/CarouselIntroPage/ScreenShots/ScreenShot01.png"),
        new Uri("https://raw.githubusercontent.com/LucioMSP/Xamarin.Forms.Examples/master/CarouselIntroPage/ScreenShots/ScreenShot02.png"),
        new Uri("https://raw.githubusercontent.com/LucioMSP/Xamarin.Forms.Examples/master/CarouselIntroPage/ScreenShots/ScreenShot03.png")
    };

    public IList<Category> Categories => new List<Category>
    {
        Category.LOGIN
    };

    public Uri ExternalUri => null;
}