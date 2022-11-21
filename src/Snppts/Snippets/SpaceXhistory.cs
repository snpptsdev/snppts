using System;

namespace Snppts.Snippets
{
    public class SpaceXhistory : IAmASnippet
    {
        public string Slug => "spacex-history";

        public string Title => "SpaceX History";

        public string Description => "Application developed in .NET MAUI (iOS and Android) consuming REST API.";

        public GitHubRepoInfo GitHubRepoInfo => new GitHubRepoInfo("EduardoReisDev/SpaceXhistory");

        public Uri ExternalUri => new Uri("https://github.com/EduardoReisDev/SpaceXhistory");

        public bool ContainsAndroidSample => true;

        public bool ContainsiOSSample => true;

        public bool ContainsUWPSample => false;

        public Sdk BuiltWith => Sdk.Maui;

        public IAmAnAuthor AuthorInfo => new EduardoReis();

        public IEnumerable<Uri> ImageUris =>  new List<Uri>
        {
            new Uri("https://user-images.githubusercontent.com/52722526/202879329-a30d1bab-fa09-41aa-9371-a4907f4519fb.png"),
            new Uri("https://user-images.githubusercontent.com/52722526/202879198-159a908f-40ab-4e7b-a159-8f2d1cf605e2.png")
        };

        public IList<Category> Categories => new List<Category>
        {
            Category.LISTS,
            Category.TABBARS,
            Category.PHOTOS,
            Category.CARDS
        };
    }
}

