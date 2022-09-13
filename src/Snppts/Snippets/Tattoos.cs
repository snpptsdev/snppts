namespace Snppts.Snippets;

public class Tattoos : IAmASnippet
{
    public string Slug => "tattoo";
    public string Title => "Awesome UI";

    public GitHubRepoInfo GitHubRepoInfo => new GitHubRepoInfo("umeshkamble/TattooApp");

    public bool ContainsAndroidSample => true;
    public bool ContainsiOSSample => true;
    public bool ContainsUWPSample => false;
    public Sdk BuiltWith => Sdk.Maui;

    public string Description => "Maui app for tattoo design,Gradient CollectionView!";

    public IAmAnAuthor AuthorInfo => new UmeshKamble();

    public IEnumerable<Uri> ImageUris => new List<Uri>
    {
        new Uri("https://user-images.githubusercontent.com/5494166/187275635-adbd12b6-dc4c-464f-a265-203ab1fe6e64.png"),
        new Uri("https://user-images.githubusercontent.com/5494166/187275659-7b4599d2-6d17-47a9-94d4-da59ef722eb4.png")
    };

    public IList<Category> Categories => new List<Category>
    {
        Category.SOCIALNETWORK, Category.FRIENDS
    };

    public Uri ExternalUri => null;
}


