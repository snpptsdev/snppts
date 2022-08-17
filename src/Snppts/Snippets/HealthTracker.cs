public class HealthTracker : IAmASnippet
{
    public string Slug => "health-tracker";
    public string Title => "Health Tracker";
    public bool ContainsAndroidSample => true;
    public bool ContainsiOSSample => true;
    public bool ContainsUWPSample => false;
    public Sdk BuiltWith => Sdk.Maui;

    public string Description => "A Health Tracker app that helps keep weight goals.";

    public IAmAnAuthor AuthorInfo => new NicholosTyler();

    public IEnumerable<Uri> ImageUris => new List<Uri>
    {
        new Uri("https://user-images.githubusercontent.com/39446369/184413816-0daa94aa-83bb-42ea-af9c-4e1f855f7122.png"),
        new Uri("https://user-images.githubusercontent.com/39446369/184413930-5a93a13d-e1d4-4d0b-9874-67f7065f4f26.png")
    };

    public IList<Category> Categories => new List<Category>
    {
        Category.LISTS,
        Category.DASHBOARD,
    };

    public GitHubRepoInfo GitHubRepoInfo => new GitHubRepoInfo("nicholostyler/Health-Tracker");

    public Uri ExternalUri => new Uri("https://github.com/nicholostyler/Health-Tracker");
}