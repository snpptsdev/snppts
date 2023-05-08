namespace Snppts.Snippets;

public class MauiApplePayment : IAmASnippet
{
    public string Slug => "Apple Payment using MAUI";
    public string Title => "Apple Payment";
    public string Description => "Apple payment for iOS using MAUI";

    public GitHubRepoInfo GitHubRepoInfo => new GitHubRepoInfo("umeshkamble/MauiApplePayment");

    public Uri ExternalUri { get; }
    public bool ContainsAndroidSample => true;
    public bool ContainsiOSSample => true;
    public bool ContainsUWPSample => false;
    public Sdk BuiltWith => Sdk.Maui;
    public IAmAnAuthor AuthorInfo => new UmeshKamble();
    public IEnumerable<Uri> ImageUris => new List<Uri> 
    { 
        new Uri("https://user-images.githubusercontent.com/5494166/226098230-2ccc334f-03aa-4f96-80fa-b43e2f9b3fab.png"),
        new Uri("https://user-images.githubusercontent.com/5494166/226098238-556add01-7963-4304-ba3c-edd143e620d5.png"),
        new Uri("https://user-images.githubusercontent.com/5494166/226098245-dc28b2f7-4ab9-4df5-bbdd-78f87684bfe3.png") 
    };
    public IList<Category> Categories => new List<Category> { Category.LOGIN };
}
