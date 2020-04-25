using Snppts.Authors;
using Snppts.Infrastructure;
using System;
using System.Collections.Generic;

namespace Snppts.Snippets
{
    public class SmartHomeApp : IAmASnippet
    {
        public string Slug => "smart-home-app";
        public string Title => "Smart Home App";
        public string GithubRepoName => "felipebaltazar/NeomorphismSmartHomeApp";
        public bool ContainsAndroidSample => true;
        public bool ContainsiOSSample => true;
        public bool ContainsUWPSample => false;

        public string Description => "Xamarin forms Challenge recreating Smart Home App UI by Amit kumar";

        public IAmAnAuthor AuthorInfo => new FelipeBaltazar();

        public IEnumerable<Uri> ImageUris => new List<Uri>
        {
            new Uri("https://user-images.githubusercontent.com/19656249/80289178-62cdbc00-8713-11ea-9333-5e13ad8bc7fc.gif")
        };

        public IList<Category> Categories => new List<Category>
        {
            Category.DASHBOARD,
            Category.WIDGETS,
            Category.NEOMORPHISM,
            Category.ARTICLES
        };

        public Uri ExternalUri => new Uri("https://medium.com/@felipedasilvabaltazar/xamarin-skiasharp-neomorfismo-7127b5e915d7");
    }
}
