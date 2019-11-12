using System;
using System.Collections.Generic;
using Snppts.Authors;
using Snppts.Infrastructure;

namespace Snppts.Snippets
{
    public class UberClone : IAmASnippet
    {
        public string Slug => "uber-clone";
        public string Title => "Uber Clone";
        public string GithubRepoName => "CrossGeeks/xUber";
        public bool ContainsAndroidSample => true;
        public bool ContainsiOSSample => true;
        public bool ContainsUWPSample => false;

        public string Description => "A Xamarin.Forms version of the Uber App to prove you can create goodlooking UI with Xamarin.Forms.";

        public IAmAnAuthor AuthorInfo => new RendyDelRosario();

        public IEnumerable<Uri> ImageUris => new List<Uri>
        {
            new Uri("https://raw.githubusercontent.com/CrossGeeks/xUber/master/Screenshots/screenshot1.png"),
            new Uri("https://raw.githubusercontent.com/CrossGeeks/xUber/master/Screenshots/screenshot2.png"),
            new Uri("https://raw.githubusercontent.com/CrossGeeks/xUber/master/Screenshots/screenshot3.png"),
            new Uri("https://raw.githubusercontent.com/CrossGeeks/xUber/master/Screenshots/screenshot4.png"),
            new Uri("https://raw.githubusercontent.com/CrossGeeks/xUber/master/Screenshots/screenshot5.png")
        };

        public IList<Category> Categories => new List<Category>
        {
            Category.MAPS, Category.SEARCH, Category.WIDGETS, Category.APPCLONE
        };

        public Uri ExternalUri => new Uri("https://www.xamboy.com/2019/07/03/introducing-xuber-uber-clone-using-xamarin-forms/");
    }
}