namespace Snppts.Snippets
{
    public class StateButtonControl
    {
        public string Slug => "StateButton-control";
        public string Title => "StateButton control";
        public string GithubRepoName => "IeuanWalker/Maui.StateButton";
        public bool ContainsAndroidSample => true;
        public bool ContainsiOSSample => true;
        public bool ContainsUWPSample => false;
        public Sdk BuiltWith => Sdk.Maui;

        public string Description => "With this control you are able to create any style of button. This is possible as it acts as a wrapper to your XAML and provides you the events/ commands and properties to bind too.\r\n\r\nIt's also 100% accessible with each platform seeing/ treating the control as a native button.";

        public IAmAnAuthor AuthorInfo => new IeuanWalker();

        public IEnumerable<Uri> ImageUris => new List<Uri>
        {
            new Uri("https://raw.githubusercontent.com/IeuanWalker/Maui.StateButton/master/Example.gif")
        };

        public IList<Category> Categories => new List<Category>
    {
        Category.NAVIGATIONS, Category.SIDEBARS
    };

        public GitHubRepoInfo GitHubRepoInfo => new GitHubRepoInfo("IeuanWalker/Maui.StateButton");

        public Uri ExternalUri => null;
    }
}
