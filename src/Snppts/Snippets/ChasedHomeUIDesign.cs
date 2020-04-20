using Snppts.Authors;
using Snppts.Extensions;
using Snppts.Infrastructure;
using System;
using System.Collections.Generic;

namespace Snppts.Snippets
{
    public class PhotoStockUIDesign : IAmASnippet
    {
        public string Slug => "Chased-Home-UI-Design";
        public string Title => "Chased Home UI Design";
        public string Description => "Xamarin Forms Chased Home UI Design";
        public GitHubRepoInfo GitHubRepoInfo => new GitHubRepoInfo("ufukhawk/Chased-Home-UI-Design");
        public Uri ExternalUri => null;
        public bool ContainsAndroidSample => true;
        public bool ContainsiOSSample => true;
        public bool ContainsUWPSample => false;
        public IAmAnAuthor AuthorInfo => new UfukHawk();

        public IEnumerable<Uri> ImageUris => new List<Uri>
        {
            new Uri("https://raw.githubusercontent.com/ufukhawk/Xamarin-Forms-UI-Library/master/Images/68747470733a2f2f696d6775722e636f6d2f4b614c417254562e706e67.png"),
            new Uri("https://raw.githubusercontent.com/ufukhawk/Xamarin-Forms-UI-Library/master/Images/68747470733a2f2f696d6775722e636f6d2f646c32507145572e706e67.png"),
        };

        public IList<Category> Categories => new List<Category>
        {
            Category.LISTS,
            Category.PHOTOS,
            Category.SEARCH,
            Category.DASHBOARD,
            Category.SIGNUPS,
            Category.PROFILES,
            Category.NAVIGATIONS,
            Category.LOGIN,
        };
    }
}
