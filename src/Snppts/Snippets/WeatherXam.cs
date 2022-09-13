namespace Snppts.Snippets
{
    public class WeatherXam : IAmASnippet
    {
        public string Slug => "weather-xam";
        public string Title => "Weather";
        public GitHubRepoInfo GitHubRepoInfo => new GitHubRepoInfo("aizendong/WeatherXam");
        public Uri ExternalUri => null;
        public bool ContainsAndroidSample => true;
        public bool ContainsiOSSample => false;
        public bool ContainsUWPSample => false;
        public Sdk BuiltWith => Sdk.XamarinForms;

        public string Description => "A Xamarin.Forms weather app with beautiful UI based on Samsung and Huawei weather apps.";

        public IAmAnAuthor AuthorInfo => new AbdoulayeDong();

        public IEnumerable<Uri> ImageUris => new List<Uri>
        {
            new Uri("https://github.com/AizenDong/WeatherXam/blob/master/Images/Weather.gif?raw=true"),

            new Uri("https://raw.githubusercontent.com/AizenDong/WeatherXam/master/Images/SearchPageLight.jpg"),
            new Uri("https://raw.githubusercontent.com/AizenDong/WeatherXam/master/Images/HomePageLight1.jpg"),
            new Uri("https://raw.githubusercontent.com/AizenDong/WeatherXam/master/Images/HomePageLight2.jpg"),
            new Uri("https://raw.githubusercontent.com/AizenDong/WeatherXam/master/Images/ManageCityPageLight.jpg"),
            new Uri("https://raw.githubusercontent.com/AizenDong/WeatherXam/master/Images/SettingsLight.jpg"),

            new Uri("https://raw.githubusercontent.com/AizenDong/WeatherXam/master/Images/SearchPageDark.jpg"),
            new Uri("https://raw.githubusercontent.com/AizenDong/WeatherXam/master/Images/HomePageDark1.jpg"),
            new Uri("https://raw.githubusercontent.com/AizenDong/WeatherXam/master/Images/HomePageDark2.jpg"),
            new Uri("https://raw.githubusercontent.com/AizenDong/WeatherXam/master/Images/ManageCityPageDark.jpg"),
            new Uri("https://raw.githubusercontent.com/AizenDong/WeatherXam/master/Images/SettingsDark.jpg"),
        };

        public IList<Category> Categories => new List<Category>
        {
            Category.APPCLONE,
            Category.CARDS, 
            Category.CHARTS, 
            Category.DASHBOARD, 
            Category.DATAGRID,
            Category.LAUNCHSCREEN,
            Category.NAVIGATIONS, 
            Category.SEARCH,
            Category.SETTINGS
        };
    }
}
