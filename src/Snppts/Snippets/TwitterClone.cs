using System;
using System.Collections.Generic;
using Snppts.Authors;
using Snppts.Infrastructure;

namespace Snppts.Snippets
{
    public class TwitterClone : IAmASnippet
    {
        public string Slug => "twitter-clone";
        public string Title => "Twitter Clone";
        public string GithubRepoName => "sthewissen/KickassUI.Twitter";
        public bool ContainsAndroidSample => true;
        public bool ContainsiOSSample => true;
        public bool ContainsUWPSample => false;

        public string Description => "A Xamarin.Forms version of the Twitter app to prove you can create goodlooking UI with Xamarin.Forms as talked about in my blogpost.";

        public IAmAnAuthor AuthorInfo => new StevenThewissen();

        public IEnumerable<Uri> ImageUris => new List<Uri>
        {
            new Uri("https://raw.githubusercontent.com/snpptsdev/MigratedImages/master/29/121.jpg"),
            new Uri("https://raw.githubusercontent.com/snpptsdev/MigratedImages/master/29/122.jpg"),
            new Uri("https://raw.githubusercontent.com/snpptsdev/MigratedImages/master/29/124.jpg"),
            new Uri("https://raw.githubusercontent.com/snpptsdev/MigratedImages/master/29/125.jpg")
        };

        public IList<Category> Categories => new List<Category>
        {
            Category.ACTIVITYFEEDS, Category.NAVIGATIONS, Category.SIDEBARS, Category.APPCLONE
        };

        public Uri ExternalUri => new Uri("https://www.thewissen.io/kickass-ui-xamarin-forms-twitter");
    }
}
