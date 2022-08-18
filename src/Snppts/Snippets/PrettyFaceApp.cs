namespace Snppts.Snippets;

public class PrettyFaceApp : IAmASnippet
{
    public string Slug => "pretty-face-app";
    public string Title => "Pretty Face App";
    public string GithubRepoName => "InnovoTecnologias/PrettyFaceApp";
    public bool ContainsAndroidSample => true;
    public bool ContainsiOSSample => true;
    public bool ContainsUWPSample => false;
    public Sdk BuiltWith => Sdk.XamarinForms;

    public string Description => "This snippet was created to give you a complete starting point for your app.";

    public GitHubRepoInfo GitHubRepoInfo => new GitHubRepoInfo("InnovoTecnologias/PrettyFaceApp");

    public IAmAnAuthor AuthorInfo => new InnovoTecnologias();

    public Uri ExternalUri => new Uri("https://www.innovotecnologias.com.ar");

    public IEnumerable<Uri> ImageUris => new List<Uri>
    {
        new Uri("https://raw.githubusercontent.com/InnovoTecnologias/PrettyFaceApp/master/Media/PrettyFaceApp.gif"),
        new Uri("https://raw.githubusercontent.com/InnovoTecnologias/PrettyFaceApp/master/Media/Preview1.jpg"),
        new Uri("https://raw.githubusercontent.com/InnovoTecnologias/PrettyFaceApp/master/Media/Preview2.jpg"),
        new Uri("https://raw.githubusercontent.com/InnovoTecnologias/PrettyFaceApp/master/Media/Preview3.jpg"),
        new Uri("https://raw.githubusercontent.com/InnovoTecnologias/PrettyFaceApp/master/Media/Preview4.jpg"),
        new Uri("https://raw.githubusercontent.com/InnovoTecnologias/PrettyFaceApp/master/Media/Preview5.jpg")
    };

    public IList<Category> Categories => new List<Category>
    {
        Category.NAVIGATIONS, Category.DASHBOARD, Category.LAUNCHSCREEN, Category.CARDS, Category.LISTS
    };
}
