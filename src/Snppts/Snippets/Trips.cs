using System;
using System.Collections.Generic;
using Snppts.Authors;
using Snppts.Extensions;
using Snppts.Infrastructure;

namespace Snppts.Snippets
{
    public class Trips : IAmASnippet
    {
        public string Slug => "trips";
        public string Title => "Awesome UI - Trips";

        public GitHubRepoInfo GitHubRepoInfo => new GitHubRepoInfo("shanranm/Trips");

        public bool ContainsAndroidSample => false;
        public bool ContainsiOSSample => true;
        public bool ContainsUWPSample => false;
        public Sdk BuiltWith => Sdk.XamarinForms;

        public string Description => "Xamarin Forms iOS Maps, CustomMarkers, Polylines, Clusters and CollectionView!";

        public IAmAnAuthor AuthorInfo => new ShanmukhaRanganath();

        public IEnumerable<Uri> ImageUris => new List<Uri>
        {
            new Uri("https://raw.githubusercontent.com/shanranm/Trips/master/screens/recording.gif")
        };

        public IList<Category> Categories => new List<Category>
        {
            Category.MAPS, Category.NAVIGATIONS
        };

        public Uri ExternalUri => null;
    }
}
