namespace Snppts.Snippets;

public class CarouselEssentials : IAmASnippet
{
    public string Slug => "carousel-essentials";

    public string Title => "Carousel Essentials";

    public string Description => "A full app built only xamarin essentials features.";

    public GitHubRepoInfo GitHubRepoInfo => new GitHubRepoInfo("alexandresanlim/App.CarouselEssentials");

    public Uri ExternalUri => null;

    public bool ContainsAndroidSample => true;

    public bool ContainsiOSSample => true;

    public bool ContainsUWPSample => false;

    public Sdk BuiltWith => Sdk.XamarinForms;

    public IAmAnAuthor AuthorInfo => new AlexandreSanlim();

    public IEnumerable<Uri> ImageUris => new List<Uri>
    {
        new Uri("https://raw.githubusercontent.com/alexandresanlim/App.OnlyEssentialsFeatures/master/App.CardTools/App.CardTools/Src/Screen/gif.gif"),
        new Uri("https://github.com/alexandresanlim/Xamarin.Essentials.FullAppFeatures/raw/master/App.CardTools/App.CardTools/Src/Screen/Android/connection.jpg?raw=true"),
        new Uri("https://github.com/alexandresanlim/Xamarin.Essentials.FullAppFeatures/raw/master/App.CardTools/App.CardTools/Src/Screen/Android/deviceinfo.jpg?raw=true"),
        new Uri("https://github.com/alexandresanlim/Xamarin.Essentials.FullAppFeatures/raw/master/App.CardTools/App.CardTools/Src/Screen/Android/flashlight.jpg?raw=true"),
        new Uri("https://github.com/alexandresanlim/Xamarin.Essentials.FullAppFeatures/raw/master/App.CardTools/App.CardTools/Src/Screen/Android/geolocation.jpg?raw=true"),
        new Uri("https://github.com/alexandresanlim/Xamarin.Essentials.FullAppFeatures/raw/master/App.CardTools/App.CardTools/Src/Screen/Android/magnometer.jpg?raw=true"),
        new Uri("https://github.com/alexandresanlim/Xamarin.Essentials.FullAppFeatures/raw/master/App.CardTools/App.CardTools/Src/Screen/Android/preference.jpg?raw=true"),
        new Uri("https://github.com/alexandresanlim/Xamarin.Essentials.FullAppFeatures/raw/master/App.CardTools/App.CardTools/Src/Screen/Android/texttospeak.jpg?raw=true"),
        new Uri("https://github.com/alexandresanlim/Xamarin.Essentials.FullAppFeatures/raw/master/App.CardTools/App.CardTools/Src/Screen/Android/unitconverter.jpg?raw=true"),
        new Uri("https://github.com/alexandresanlim/Xamarin.Essentials.FullAppFeatures/raw/master/App.CardTools/App.CardTools/Src/Screen/Android/whats.jpg?raw=true"),
        new Uri("https://github.com/alexandresanlim/App.OnlyEssentialsFeatures/raw/master/App.CardTools/App.CardTools/Src/Screen/iOS/connection.png?raw=true"),
        new Uri("https://github.com/alexandresanlim/App.OnlyEssentialsFeatures/raw/master/App.CardTools/App.CardTools/Src/Screen/iOS/deviceinfo.png?raw=true"),
        new Uri("https://github.com/alexandresanlim/App.OnlyEssentialsFeatures/raw/master/App.CardTools/App.CardTools/Src/Screen/iOS/flashlight.png?raw=true"),
        new Uri("https://github.com/alexandresanlim/App.OnlyEssentialsFeatures/raw/master/App.CardTools/App.CardTools/Src/Screen/iOS/geolocation.png?raw=true"),
        new Uri("https://github.com/alexandresanlim/App.OnlyEssentialsFeatures/raw/master/App.CardTools/App.CardTools/Src/Screen/iOS/magnometer.png?raw=true"),
        new Uri("https://github.com/alexandresanlim/App.OnlyEssentialsFeatures/raw/master/App.CardTools/App.CardTools/Src/Screen/iOS/preference.png?raw=true"),
        new Uri("https://github.com/alexandresanlim/App.OnlyEssentialsFeatures/raw/master/App.CardTools/App.CardTools/Src/Screen/iOS/texttospeak.png?raw=true"),
        new Uri("https://github.com/alexandresanlim/App.OnlyEssentialsFeatures/raw/master/App.CardTools/App.CardTools/Src/Screen/iOS/unitconverter.png?raw=true"),
        new Uri("https://github.com/alexandresanlim/App.OnlyEssentialsFeatures/raw/master/App.CardTools/App.CardTools/Src/Screen/iOS/whats.png?raw=true")
    };

    public IList<Category> Categories => new List<Category>
    {
        Category.CARDS,
        Category.CAROUSEL
    };
}
