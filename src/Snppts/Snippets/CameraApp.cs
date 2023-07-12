namespace Snppts.Snippets;

public class CameraApp : IAmASnippet
{
    public string Slug => "camera-app";
    public string Title => "Camera App";
    public string Description => ".NET MAUI implementation of a Midjourney design for a Camera Viewer app.";
    public GitHubRepoInfo GitHubRepoInfo => new GitHubRepoInfo("rretamal/MidjourneyCameraApp");
    public Uri ExternalUri => null;
    public bool ContainsAndroidSample => true;
    public bool ContainsiOSSample => true;
    public bool ContainsUWPSample => false;
    public Sdk BuiltWith => Sdk.Maui;
    public IAmAnAuthor AuthorInfo => new RicardoRetamal();

    public IEnumerable<Uri> ImageUris => new List<Uri>
    {
        new Uri("https://github.com/rretamal/MidjourneyCameraApp/blob/main/MidjourneyCameraApp/Images/1_mYN3aXSpY5v5QnJ_CKfaCw.png?raw=true"),
    };

    public IList<Category> Categories => new List<Category>
    {
        Category.DASHBOARD,
        Category.TABBARS,
        Category.NAVIGATIONS
    };
}
