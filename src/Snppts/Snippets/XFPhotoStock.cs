using Snppts.Authors;
using Snppts.Extensions;
using Snppts.Infrastructure;
using System;
using System.Collections.Generic;

namespace Snppts.Snippets
{
    public class PhotoStockUIDesign : IAmASnippet
    {
        public string Slug => "XamarinForms-PhotoStock-UI-Design";
        public string Title => "Xamarin Forms PhotoStock UI Design";
        public string Description => "Xamarin Forms photo stock application design.";
        public GitHubRepoInfo GitHubRepoInfo => new GitHubRepoInfo("ufukhawk/XamarinForms-PhotoStock-UI-Design");
        public Uri ExternalUri => null;
        public bool ContainsAndroidSample => true;
        public bool ContainsiOSSample => true;
        public bool ContainsUWPSample => false;
        public IAmAnAuthor AuthorInfo => new UfukHawk();

        public IEnumerable<Uri> ImageUris => new List<Uri>
        {
            new Uri("https://raw.githubusercontent.com/ufukhawk/Xamarin-Forms-UI-Library/master/Images/PhotoStock.gif"),
            new Uri("https://raw.githubusercontent.com/ufukhawk/Xamarin-Forms-UI-Library/master/Images/PhotoStock.png"),
            new Uri("https://raw.githubusercontent.com/ufukhawk/Xamarin-Forms-UI-Library/master/Images/PhotoStocksc2.png"),
            
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
