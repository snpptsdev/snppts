namespace Snppts.Snippets;

public class ConcentricOnBoarding : IAmASnippet
{
    public string Slug => "concentric-onboarding";
    public string Title => "Concentric OnBoarding";
    public GitHubRepoInfo GitHubRepoInfo => new GitHubRepoInfo("felipebaltazar/Xam-ConcentricOnboarding");
    public bool ContainsAndroidSample => true;
    public bool ContainsiOSSample => true;
    public bool ContainsUWPSample => false;
    public Sdk BuiltWith => Sdk.XamarinForms;

    public string Description => "ConcentricOnboarding clone using skiasharp and xamarin forms based on SwiftUI Library exyte/ConcentricOnboarding";

    public IAmAnAuthor AuthorInfo => new FelipeBaltazar();

    public IEnumerable<Uri> ImageUris => new List<Uri>
    {
        new Uri("https://user-images.githubusercontent.com/19656249/68100432-cbe01f80-fea6-11e9-9044-fc3a10e4422a.gif"),
    };

    public IList<Category> Categories => new List<Category>
    {
        Category.DASHBOARD,
        Category.WIDGETS
    };

    public Uri ExternalUri => new Uri("https://medium.com/@felipedasilvabaltazar/xamarin-transi%C3%A7%C3%B5es-com-skiasharp-6c8ac2b09589");
}
