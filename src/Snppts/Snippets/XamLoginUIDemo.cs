
using Snppts.Authors;
using Snppts.Extensions;
using Snppts.Infrastructure;
using System;
using System.Collections.Generic;

namespace Snppts.Snippets
{
    public class XamLoginUI : IAmASnippet
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
            new Uri("https://raw.githubusercontent.com/ufukhawk/Xamarin-Forms-UI-Library/master/Images/sc_10.png"),
            new Uri("https://raw.githubusercontent.com/ufukhawk/Xamarin-Forms-UI-Library/master/Images/sc_13.png"),
            new Uri("https://raw.githubusercontent.com/ufukhawk/Xamarin-Forms-UI-Library/master/Images/sc_14.png"),
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
