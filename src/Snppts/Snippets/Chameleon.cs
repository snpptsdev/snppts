using System;
using System.Collections.Generic;
using Snppts.Authors;
using Snppts.Extensions;
using Snppts.Infrastructure;

namespace Snppts.Snippets
{
    public class Chameleon : IAmASnippet
    {
        public string Slug => "chameleon";
        public string Title => "Chameleon";
        public GitHubRepoInfo GitHubRepoInfo => new GitHubRepoInfo("sthewissen/KickassUI.Chameleon");
        public bool ContainsAndroidSample => true;
        public bool ContainsiOSSample => true;
        public bool ContainsUWPSample => false;

        public string Description => "A Xamarin.Forms version of the Chameleon app to prove you can create goodlooking UI with Xamarin.Forms as talked about in my blogpost.";

        public IAmAnAuthor AuthorInfo => new StevenThewissen();

        public IEnumerable<Uri> ImageUris => new List<Uri>
        {
            new Uri("https://raw.githubusercontent.com/sthewissen/KickassUI.Chameleon/master/ios1.png"),
            new Uri("https://raw.githubusercontent.com/sthewissen/KickassUI.Chameleon/master/ios2.png"),
            new Uri("https://raw.githubusercontent.com/sthewissen/KickassUI.Chameleon/master/droid1.jpg"),
            new Uri("https://raw.githubusercontent.com/sthewissen/KickassUI.Chameleon/master/droid2.jpg")
        };

        public IList<Category> Categories => new List<Category>
        {
            Category.CARDS, Category.PHOTOS
        };

        public Uri ExternalUri => new Uri("https://www.thewissen.io/creating-an-encyclopedia-page-in-xamarin-forms");
    }
}
