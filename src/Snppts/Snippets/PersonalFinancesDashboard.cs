using System;
using System.Collections.Generic;
using Snppts.Authors;
using Snppts.Infrastructure;

namespace Snppts.Snippets
{
    public class PersonalFinancesDashboard : IAmASnippet
    {
        public string Slug => "personal-finances-dashboard";
        public string Title => "Personal Finances Dashboard";
        public string GithubRepoName => "ricardoprestes/MyDimDim";
        public bool ContainsAndroidSample => true;
        public bool ContainsiOSSample => true;
        public bool ContainsUWPSample => false;

        public string Description => "Sample of a dashboard page for a personal finances app with Xamarin.Forms";

        public IAmAnAuthor AuthorInfo => new RicardoPrestes();

        public IEnumerable<Uri> ImageUris => new List<Uri>
        {
            new Uri("https://raw.githubusercontent.com/ricardoprestes/MyDimDim/master/screenshot/iOS.png"),
            new Uri("https://raw.githubusercontent.com/ricardoprestes/MyDimDim/master/screenshot/Android.jpg")
        };

        public IList<Category> Categories => new List<Category>
        {
            Category.DASHBOARD,
            Category.CHARTS,
            Category.WIDGETS
        };

        public Uri ExternalUri => null;
    }
}
