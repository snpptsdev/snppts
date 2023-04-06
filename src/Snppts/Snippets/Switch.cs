namespace Snppts.Snippets
{
    public class Switch
    {
        public string Slug => "Switch";
        public string Title => "Switch control";
        public GitHubRepoInfo GitHubRepoInfo => new GitHubRepoInfo("IeuanWalker/Maui.Switch");
        public bool ContainsAndroidSample => true;
        public bool ContainsiOSSample => true;
        public bool ContainsUWPSample => false;
        public Sdk BuiltWith => Sdk.Maui;

        public string Description => "A control that allows you to design any type of switch/ toggle for .NET MAUI. It's also 100% accessible.";

        public IAmAnAuthor AuthorInfo => new IeuanWalker();

        public IEnumerable<Uri> ImageUris => new List<Uri>
        {
            new Uri("https://raw.githubusercontent.com/IeuanWalker/Maui.Switch/master/Doc/SampleApp.gif")
        };
        public IList<Category> Categories => new List<Category>
        {
            Category.SETTINGS, Category.FILTER
        };
        public Uri ExternalUri => null;
    }
}
