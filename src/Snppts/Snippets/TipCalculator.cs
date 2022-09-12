namespace Snppts.Snippets;
    public class TipCalculator
    {
        public string Slug => "tip-calculator";
        public string Title => "Tip Calculator";
        public bool ContainsAndroidSample => true;
        public bool ContainsiOSSample => true;
        public bool ContainsUWPSample => false;
        public Sdk BuiltWith => Sdk.Maui;

        public string Description => "A Tip Calculator to manage splitting with friends.";

        public IAmAnAuthor AuthorInfo => new NicholosTyler();

        public IEnumerable<Uri> ImageUris => new List<Uri>
        {
            new Uri("https://user-images.githubusercontent.com/39446369/189417052-82d1961a-7b7a-4c83-a02b-ccc07103b1a2.png"),
        };

        public IList<Category> Categories => new List<Category>
        {
            Category.CALCULATORS,
        };

        public GitHubRepoInfo GitHubRepoInfo => new GitHubRepoInfo("nicholostyler/MAUI-Tip-Calculator");

        public Uri ExternalUri => new Uri("https://github.com/nicholostyler/MAUI-Tip-Calculator");
    }
