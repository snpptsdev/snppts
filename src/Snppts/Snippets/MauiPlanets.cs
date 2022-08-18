namespace Snppts.Snippets;

public class MauiPlanets : IAmASnippet
{
    public string Slug => "maui-planets";
    public string Title => "Maui Planets";
    public GitHubRepoInfo GitHubRepoInfo => new GitHubRepoInfo("naweed/MauiPlanets");
    public bool ContainsAndroidSample => true;
    public bool ContainsiOSSample => true;
    public bool ContainsUWPSample => false;
    public bool ContainsmacOSSample => false;
    public Sdk BuiltWith => Sdk.Maui;

    public string Description => "This snippet shows Planets Mobile App UI built using .Net Maui. Implements the Dribbble design from https://dribbble.com/shots/15592060-Planet-Mobile-App.";

    public IAmAnAuthor AuthorInfo => new NaweedAkram();

    public IEnumerable<Uri> ImageUris => new List<Uri>
    {
        new Uri("https://github.com/naweed/MauiPlanets/blob/main/Images/001.png?raw=true"),
        new Uri("https://github.com/naweed/MauiPlanets/blob/main/Images/002.png?raw=true"),
        new Uri("https://github.com/naweed/MauiPlanets/blob/main/Images/003.png?raw=true")
    };

    public IList<Category> Categories => new List<Category>
    {
        Category.APPCLONE
    };

    public Uri ExternalUri => new Uri("https://blogs.xgenoapps.com/post/2022/07/15/maui-planets-part-2");
}
