namespace Snppts.Snippets;

public class LoginValidation : IAmASnippet
{
    public string Slug => "simple-login-Validation";
    public string Title => "Login Page Validation";
    public string Description => "A simple login validation with custom error message";

    public GitHubRepoInfo GitHubRepoInfo => new GitHubRepoInfo("umeshkamble/PageValidations");

    public Uri ExternalUri { get; }
    public bool ContainsAndroidSample => true;
    public bool ContainsiOSSample => true;
    public bool ContainsUWPSample => false;
    public Sdk BuiltWith => Sdk.Maui;
    public IAmAnAuthor AuthorInfo => new UmeshKamble();
    public IEnumerable<Uri> ImageUris => new List<Uri> 
    { 
        new Uri("https://user-images.githubusercontent.com/5494166/235351183-9ad88d9d-541b-40d5-9d9a-5784ee5298e0.png"),
        new Uri("https://user-images.githubusercontent.com/5494166/235351184-7494b76a-dde9-495b-81cc-89a1495a34db.png"),
        new Uri("https://user-images.githubusercontent.com/5494166/235351185-387ab6c9-8faf-4b8f-9cbe-ec341983d4f5.png") 
    };
    public IList<Category> Categories => new List<Category> { Category.LOGIN };
}
