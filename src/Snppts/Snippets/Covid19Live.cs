using Snppts.Authors;
using Snppts.Extensions;
using Snppts.Infrastructure;
using System;
using System.Collections.Generic;

namespace Snppts.Snippets
{
    public class Covid19Live : IAmASnippet
    {
        public string Slug => "covid19-live";
        public string Title => "Covid-19 Live";
        public string Description => "Developed in XamarinForms with the aim of tracking Covid-19 cases with data from affected countries, including Brazil.";
        public GitHubRepoInfo GitHubRepoInfo => new GitHubRepoInfo("Altevir/xamarinforms-covid19");
        public Uri ExternalUri => null;
        public bool ContainsAndroidSample => true;
        public bool ContainsiOSSample => true;
        public bool ContainsUWPSample => false;
        public Sdk BuiltWith => Sdk.XamarinForms;
        public IAmAnAuthor AuthorInfo => new AltevirCardosoNeto();

        public IEnumerable<Uri> ImageUris => new List<Uri>
        {
            new Uri("https://user-images.githubusercontent.com/11803107/79575316-f827db00-8097-11ea-826e-c94107b2ce1d.png"),
            new Uri("https://user-images.githubusercontent.com/11803107/79575346-04ac3380-8098-11ea-817e-5b663dd33a8a.png"),
            new Uri("https://user-images.githubusercontent.com/11803107/79575567-62d91680-8098-11ea-8655-6712af67776b.PNG"),
            new Uri("https://user-images.githubusercontent.com/11803107/79575597-6c627e80-8098-11ea-8e3a-fc6f218853e7.PNG"),
            new Uri("https://user-images.githubusercontent.com/11803107/79587522-0b8f7200-80a9-11ea-8830-3d293824acaa.gif")
        };

        public IList<Category> Categories => new List<Category>
        {
            Category.LISTS,
            Category.PHOTOS,
            Category.SEARCH,
            Category.DASHBOARD,
            Category.SETTINGS,
            Category.FILTER
        };
    }
}
