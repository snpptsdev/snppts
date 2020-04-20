using Snppts.Authors;
using Snppts.Extensions;
using Snppts.Infrastructure;
using System;
using System.Collections.Generic;

namespace Snppts.Snippets
{
    public class XamCall : IAmASnippet
    {
        public string Slug => "Xam-Call";
        public string Title => "XamCall";
        public string Description => "Xamarin Forms Call Screen UI Design";
        public GitHubRepoInfo GitHubRepoInfo => new GitHubRepoInfo("ufukhawk/XamCall");
        public Uri ExternalUri => null;
        public bool ContainsAndroidSample => true;
        public bool ContainsiOSSample => true;
        public bool ContainsUWPSample => false;
        public IAmAnAuthor AuthorInfo => new UfukHawk();

        public IEnumerable<Uri> ImageUris => new List<Uri>
        {
            new Uri("https://raw.githubusercontent.com/ufukhawk/Xamarin-Forms-UI-Library/master/Images/xamcall.gif"),
        };

        public IList<Category> Categories => new List<Category>
        {
            Category.PHOTOS,
            Category.DASHBOARD,
            Category.PROFILES,
            Category.NAVIGATIONS,
        };
    }
}
