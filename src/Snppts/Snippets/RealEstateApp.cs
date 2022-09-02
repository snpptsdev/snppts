namespace Snppts.Snippets
{
    public class RealEstateApp : IAmASnippet
    {
        public string Slug => "realestateapp";

        public string Title => "Real Estate App";

        public string Description => "dotnet MAUI UI Sample for Real Estat App";

        public GitHubRepoInfo GitHubRepoInfo => new GitHubRepoInfo("marcfabregatb/RealEstate.App");

        public Uri ExternalUri => null;

        public bool ContainsAndroidSample => true;

        public bool ContainsiOSSample => true;

        public bool ContainsUWPSample => false;

        public Sdk BuiltWith => Sdk.Maui;

        public IAmAnAuthor AuthorInfo => new MarcFabregat();

        public IEnumerable<Uri> ImageUris => new List<Uri>
        {
            new Uri("https://raw.githubusercontent.com/marcfabregatb/RealEstate.App/main/realEstateApp.gif")
        };

        public IList<Category> Categories => new List<Category>
        {
            Category.STORES,
            Category.APPCLONE,
            Category.LISTS,
            Category.CAROUSEL
        };
    }
}
