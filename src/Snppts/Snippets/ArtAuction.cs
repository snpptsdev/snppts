namespace Snppts.Snippets;

public class ArtAuction : IAmASnippet
{
    public string Slug => "art-auction";
    public string Title => "Art Auction";
    public GitHubRepoInfo GitHubRepoInfo => new GitHubRepoInfo("kphillpotts/ArtAuction");
    public bool ContainsAndroidSample => true;
    public bool ContainsiOSSample => true;
    public bool ContainsUWPSample => false;
    public Sdk BuiltWith => Sdk.XamarinForms;

    public string Description => "Art Auction site, with multiple expanding popovers and interesting transitions";

    public IAmAnAuthor AuthorInfo => new KymPhillpotts();

    public IEnumerable<Uri> ImageUris => new List<Uri>
    {
        new Uri("https://kymphillpotts.com/assets/images/posts/artauction-screen1.png"),
        new Uri("https://kymphillpotts.com/assets/images/posts/artauction-screen3.png"),
        new Uri("https://kymphillpotts.com/assets/images/posts/artauction-screen2.png")
    };

    public IList<Category> Categories => new List<Category>
    {
        Category.CARDS, Category.LISTS, Category.POPOVERS
    };

    public Uri ExternalUri => new Uri("https://kymphillpotts.com/xamarin-forms-ui-challenge-artauction.html");
}
