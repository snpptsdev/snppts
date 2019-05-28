using System;
using System.Collections.Generic;
using Snppts.Authors;
using Snppts.Infrastructure;

namespace Snppts.Snippets
{
    public class RunkeeperClone : IAmASnippet
    {
        public string Slug => "runkeeper-clone";
        public string Title => "Runkeeper Clone";
        public string GithubRepoName => "sthewissen/KickassUI.Runkeeper";
        public bool ContainsAndroidSample => true;
        public bool ContainsiOSSample => true;
        public bool ContainsUWPSample => false;

        public string Description => "A Xamarin.Forms version of the Runkeeper app to prove you can create goodlooking UI with Xamarin.Forms as talked about in my blogpost on: <a href=\"https://www.thewissen.io/xamarin-forms-ui-runkeeper/\" target=\"_blank\">https://www.thewissen.io/xamarin-forms-ui-runkeeper/</a>";

        public IAmAnAuthor AuthorInfo => new StevenThewissen();

        public IEnumerable<Uri> ImageUris => new List<Uri>
        {
            new Uri("https://raw.githubusercontent.com/snpptsdev/MigratedImages/master/49/126.jpg"),
            new Uri("https://raw.githubusercontent.com/snpptsdev/MigratedImages/master/49/127.jpg"),
            new Uri("https://raw.githubusercontent.com/snpptsdev/MigratedImages/master/49/128.jpg"),
            new Uri("https://raw.githubusercontent.com/snpptsdev/MigratedImages/master/49/129.jpg")
        };

        public IList<Category> Categories => new List<Category>
        {
            Category.MAPS, Category.NAVIGATIONS, Category.DASHBOARD
        };
    }
}
