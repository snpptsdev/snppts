
using Snppts.Authors;
using Snppts.Extensions;
using Snppts.Infrastructure;
using System;
using System.Collections.Generic;

namespace Snppts.Snippets
{
    public class PhotoStockUIDesign : IAmASnippet
    {
        public string Slug => "Xam-Login-UI-Demo";
        public string Title => "XamLogin UI Demo";
        public string Description => "Xamarin Forms Login UI";
        public GitHubRepoInfo GitHubRepoInfo => new GitHubRepoInfo("ufukhawk/XamUIDemo");
        public Uri ExternalUri => null;
        public bool ContainsAndroidSample => true;
        public bool ContainsiOSSample => true;
        public bool ContainsUWPSample => false;
        public IAmAnAuthor AuthorInfo => new UfukHawk();

        public IEnumerable<Uri> ImageUris => new List<Uri>
        {
            new Uri("https://imgur.com/WoMiZov.png"),
            new Uri("https://imgur.com/ujESYOB.png"),
            new Uri("https://imgur.com/d6w0gZf.png"),
        };

        public IList<Category> Categories => new List<Category>
        {
            Category.PHOTOS,
            Category.DASHBOARD,
            Category.SIGNUPS,
            Category.PROFILES,
            Category.NAVIGATIONS,
            Category.LOGIN,
        };
    }
}
