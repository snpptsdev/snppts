namespace Snppts.Snippets;

public class SimplestWeather : IAmASnippet
{
    public string Slug => "simplest-weather";

    public string Title => "Weather--";

    public string Description => "This is an educational app showcasing a GraphQL Weather API consumed by a Xamarin.Forms app. This repository can be used as a template for a modern Xamarin.Forms 4.3 app with clean and testable architecture consuming a GraphQL endpoint.";

    public GitHubRepoInfo GitHubRepoInfo => new GitHubRepoInfo("Sankra/GraphQLDotNet");

    public Uri ExternalUri => new Uri("https://hjerpbakk.com");

    public bool ContainsAndroidSample => true;

    public bool ContainsiOSSample => true;

    public bool ContainsUWPSample => false;

    public Sdk BuiltWith => Sdk.XamarinForms;

    public IAmAnAuthor AuthorInfo => new RunarOvesenHjerpbakk();

    public IEnumerable<Uri> ImageUris => new [] 
    { 
        new Uri("https://raw.githubusercontent.com/Sankra/GraphQLDotNet/master/locations-light.PNG"),
        new Uri("https://raw.githubusercontent.com/Sankra/GraphQLDotNet/master/locations-dark.PNG"),
        new Uri("https://raw.githubusercontent.com/Sankra/GraphQLDotNet/master/weather-dark.PNG"),
        new Uri("https://raw.githubusercontent.com/Sankra/GraphQLDotNet/master/add-location-dark.PNG") 
    };

    public IList<Category> Categories => new[] { Category.TABBARS, Category.APPCLONE, Category.FILTER, Category.DATAGRID, Category.LISTS };
}
