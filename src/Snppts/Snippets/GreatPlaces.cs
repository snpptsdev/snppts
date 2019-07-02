using System;
using System.Collections.Generic;
using Snppts.Authors;
using Snppts.Infrastructure;

namespace Snppts.Snippets
{
    public class GreatPlaces : IAmASnippet
    {
        public string Slug => "great-places";
        public string Title => "Great Places";
        public string GithubRepoName => "kphillpotts/XamarinFormsLayoutChallenges";
        public bool ContainsAndroidSample => true;
        public bool ContainsiOSSample => true;
        public bool ContainsUWPSample => false;

        public string Description => "A ListView layout that has images and overlayed profile and views indicators.";

        public IAmAnAuthor AuthorInfo => new KymPhillpotts();

        public IEnumerable<Uri> ImageUris => new List<Uri>
        {
            new Uri("https://raw.githubusercontent.com/snpptsdev/MigratedImages/master/82/132.jpg"),
            new Uri("https://raw.githubusercontent.com/snpptsdev/MigratedImages/master/82/133.jpg")
        };

        public IList<Category> Categories => new List<Category>
        {
            Category.LISTS, Category.PHOTOS
        };

        public Uri ExternalUri => null;
    }
}
