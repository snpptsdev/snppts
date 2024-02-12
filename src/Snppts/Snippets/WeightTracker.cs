namespace Snppts.Snippets
{
    public class WeightTrackerApp : IAmASnippet
    {
        public string Slug => "weight-tracker-app";
        public string Title => "Weight Tracker App";
        public GitHubRepoInfo GitHubRepoInfo => new GitHubRepoInfo("fdmomtaz/MauiWeightTracker");
        public bool ContainsAndroidSample => true;
        public bool ContainsiOSSample => true;
        public bool ContainsUWPSample => true;
        public Sdk BuiltWith => Sdk.Maui;
        public Uri ExternalUri => null;

        public string Description => "A simple, user-friendly .NET MAUI weight tracker app with a clean design for anyone looking to explore .NET MAUI development.";

        public IAmAnAuthor AuthorInfo => new FarshadMomtaz();

        public IEnumerable<Uri> ImageUris => new List<Uri>
        {
            new Uri("https://raw.githubusercontent.com/fdmomtaz/WeightTracker-DotNetMaui/main/Pictures/WelcomeScreen.gif"),
            new Uri("https://raw.githubusercontent.com/fdmomtaz/WeightTracker-DotNetMaui/main/Pictures/HomeScreen.png"),
            new Uri("https://raw.githubusercontent.com/fdmomtaz/WeightTracker-DotNetMaui/main/Pictures/HomeScreenWeightLoss.png"),
            new Uri("https://raw.githubusercontent.com/fdmomtaz/WeightTracker-DotNetMaui/main/Pictures/HomeScreenWeightGain.png"),
            new Uri("https://raw.githubusercontent.com/fdmomtaz/WeightTracker-DotNetMaui/main/Pictures/GraphAndHistory.png"),
            new Uri("https://raw.githubusercontent.com/fdmomtaz/WeightTracker-DotNetMaui/main/Pictures/Settings.png"),
        };

        public IList<Category> Categories => new List<Category>
        {
            Category.CHARTS,
            Category.DATAGRID,
            Category.PROFILES,
            Category.LAUNCHSCREEN,
            Category.DASHBOARD,
            Category.CALCULATORS
        };
    }
}