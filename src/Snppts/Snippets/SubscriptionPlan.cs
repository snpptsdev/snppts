namespace Snppts.Snippets;

public class SubscriptionPlan : IAmASnippet
{
    public string Slug => "subscription-plan";

    public string Title => "Subscription Plan";

    public string Description => "A simple subscription plan page";

    public GitHubRepoInfo GitHubRepoInfo => new GitHubRepoInfo("alexandresanlim/XamarinUI.SubscriptionPlan");

    public Uri ExternalUri => null;

    public bool ContainsAndroidSample => true;

    public bool ContainsiOSSample => true;

    public bool ContainsUWPSample => false;
    public Sdk BuiltWith => Sdk.XamarinForms;

    public IAmAnAuthor AuthorInfo => new AlexandreSanlim();

    public IEnumerable<Uri> ImageUris => new List<Uri>
    {
        new Uri("https://github.com/alexandresanlim/XamarinUI.SubscriptionPlan/raw/master/SubscriptionPlan.XamarinUI/SubscriptionPlan.XamarinUI/Screenshots/animation.gif?raw=true"),
        new Uri("https://raw.githubusercontent.com/alexandresanlim/SubscriptionPlan.XamarinUI/master/SubscriptionPlan.XamarinUI/SubscriptionPlan.XamarinUI/Screenshots/android.jpg"),
        new Uri("https://raw.githubusercontent.com/alexandresanlim/SubscriptionPlan.XamarinUI/master/SubscriptionPlan.XamarinUI/SubscriptionPlan.XamarinUI/Screenshots/ios.png")
    };

    public IList<Category> Categories => new List<Category>
    {
        Category.CARDS,
        Category.LISTS,
        Category.CAROUSEL
    };
}
