namespace Snppts.Snippets
{
    public class TemperatureCalculator : IAmASnippet
    {
        public string Slug => "temperature-calculator";
        public string Title => "Temperature Calculator";
        public string GithubRepoName => "sergy2k/CentiFahrCalc";
        public bool ContainsAndroidSample => true;
        public bool ContainsiOSSample => true;
        public bool ContainsUWPSample => true;

        public string Description => "This snippet is a temperature calculator which performs conversion between temperature in Centigrade and Fahrenheit.";

        public IAmAnAuthor AuthorInfo => new SergeiS();

        public IEnumerable<Uri> ImageUris => new List<Uri>
        {
            new Uri("https://raw.githubusercontent.com/sergy2k/CentiFahrCalc/master/.github/images/TemperatureCalculatorScreenshot01.jpg"),
        };

        public IList<Category> Categories => new List<Category>
        {
            Category.CALCULATORS
        };

        public GitHubRepoInfo GitHubRepoInfo => new GitHubRepoInfo("sergy2k/CentiFahrCalc");

        public Uri ExternalUri => null;

        public Sdk BuiltWith => Sdk.Maui;
    }
}
