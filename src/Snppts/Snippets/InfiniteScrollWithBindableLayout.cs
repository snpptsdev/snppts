namespace Snppts.Snippets;

public class InfiniteScrollWithBindableLayout : IAmASnippet
{
    public string Slug => "InfiniteScroll";
    public string Title => "Infinite Scrolling using BindableLayout";
    public GitHubRepoInfo GitHubRepoInfo => new GitHubRepoInfo("umeshkamble/InfiniteScrollWithBindableLayout");
    public bool ContainsAndroidSample => true;
    public bool ContainsiOSSample => true;
    public bool ContainsUWPSample => false;
    public Sdk BuiltWith => Sdk.Sdk.Maui;

    public string Description => "Infinite scroll with bindable layout.";

    public IAmAnAuthor AuthorInfo => new UmeshKamble();

    public IEnumerable<Uri> ImageUris => new List<Uri>
    {
        new Uri("https://github.com/umeshkamble/InfiniteScrollWithBindableLayout/assets/5494166/2e94dd77-4d09-4000-93d7-59b60028e37e"),
        new Uri("https://github.com/umeshkamble/InfiniteScrollWithBindableLayout/assets/5494166/8a7c3c8b-06b3-4928-b3b0-81a921f85132")
    };

    public IList<Category> Categories => new List<Category>
    {
        Category.LISTS
    };

    public Uri ExternalUri => null;
}
