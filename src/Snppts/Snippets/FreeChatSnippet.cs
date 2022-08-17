namespace Snppts.Snippets;

public class FreeChatSnippet : IAmASnippet
{
    public string Slug => "Chat app UI";

    public string Title => "FreeChat";

    public string Description => "User interface demonstrating a pretty chat application";

    public GitHubRepoInfo GitHubRepoInfo => new GitHubRepoInfo("DamienDoumer/freechat");

    public Uri ExternalUri => null;

    public bool ContainsAndroidSample => true;

    public bool ContainsiOSSample => true;

    public bool ContainsUWPSample => false;
    
    public Sdk BuiltWith => Sdk.XamarinForms;

    public IAmAnAuthor AuthorInfo => new DamienDoumer();

    public IEnumerable<Uri> ImageUris => new List<Uri>
    {
        new Uri("https://raw.githubusercontent.com/DamienDoumer/freechat/master/images/freechatAndroidDemo.gif"),
        new Uri("https://raw.githubusercontent.com/DamienDoumer/freechat/master/images/freechatiOSDemo.gif")
    };

    public IList<Category> Categories => new List<Category>
    {
        Category.MESSAGING,
        Category.SOCIALNETWORK,
        Category.FRIENDS
    };
}
