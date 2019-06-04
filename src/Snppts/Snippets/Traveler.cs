using System;
using System.Collections.Generic;
using Snppts.Authors;
using Snppts.Infrastructure;

namespace Snppts.Snippets
{
    public class Traveler : IAmASnippet
    {
        public string Slug => "traveler";
        public string Title => "Traveler";
        public string GithubRepoName => "sthewissen/KickassUI.Traveler";
        public bool ContainsAndroidSample => true;
        public bool ContainsiOSSample => true;
        public bool ContainsUWPSample => false;

        public string Description => "A Xamarin.Forms version of the Traveler app to prove you can create goodlooking UI with Xamarin.Forms as talked about in my blogpost on: <a href=\"https://www.thewissen.io/travel-broadens-the-mind/\" target=\"_blank\">https://www.thewissen.io/travel-broadens-the-mind/</a>";

        public IAmAnAuthor AuthorInfo => new StevenThewissen();

        public IEnumerable<Uri> ImageUris => new List<Uri>
        {
            new Uri("https://raw.githubusercontent.com/sthewissen/KickassUI.Traveler/master/droid.jpg"),
            new Uri("https://raw.githubusercontent.com/sthewissen/KickassUI.Traveler/master/ios.png")
        };

        public IList<Category> Categories => new List<Category>
        {
            Category.CARDS, Category.LISTS, Category.DASHBOARD
        };
    }
}
