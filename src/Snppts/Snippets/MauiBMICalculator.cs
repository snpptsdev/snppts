namespace Snppts.Snippets;

public class MauiBMICalculator : IAmASnippet
{
    public string Slug => "maui-bmi-calc";
    public string Title => "Maui BMI Calculator";
    public GitHubRepoInfo GitHubRepoInfo => new GitHubRepoInfo("naweed/MauiBMICalculator");
    public bool ContainsAndroidSample => true;
    public bool ContainsiOSSample => true;
    public bool ContainsUWPSample => false;
    public bool ContainsmacOSSample => false;
    public Sdk BuiltWith => Sdk.Maui;

    public string Description => "A simple and gorgeous BMI Calculator built using .NET MAUI and Skia Sharp. Inspired by this Dribble design (https://dribbble.com/shots/7735120-BMI-BMR-Calculator-App-Free-UI-Kit-1-Dribbble-Invitation).";

    public IAmAnAuthor AuthorInfo => new NaweedAkram();

    public IEnumerable<Uri> ImageUris => new List<Uri>
    {
        new Uri("https://user-images.githubusercontent.com/103980/185797398-bc4883c9-3b4f-4754-acfd-d2a985d61463.png"),
        new Uri("https://user-images.githubusercontent.com/103980/185797403-66ef1e5f-ce64-4500-a810-faade573d63c.png"),
        new Uri("https://user-images.githubusercontent.com/103980/185797405-8bdc2f4b-2d9c-4910-9cbb-eb67f0d9801d.png")
    };

    public IList<Category> Categories => new List<Category>
    {
        Category.CALCULATORS
    };

    public Uri ExternalUri => null;
}
