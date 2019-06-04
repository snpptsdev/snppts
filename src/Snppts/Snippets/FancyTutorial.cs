using System;
using System.Collections.Generic;
using Snppts.Authors;
using Snppts.Infrastructure;

namespace Snppts.Snippets
{
    public class FancyTutorial : IAmASnippet
    {
        public string Slug => "fancy-tutorial";
        public string Title => "Fancy Tutorial";
        public string GithubRepoName => "sthewissen/KickassUI.FancyTutorial";
        public bool ContainsAndroidSample => true;
        public bool ContainsiOSSample => true;
        public bool ContainsUWPSample => false;

        public string Description => "A simple Xamarin.Forms tutorial screen as talked about in my blogpost on: <a href=\"https://www.thewissen.io/simple-good-looking-app-tutorial\" target=\"_blank\">https://www.thewissen.io/simple-good-looking-app-tutorial</a>";

        public IAmAnAuthor AuthorInfo => new StevenThewissen();

        public IEnumerable<Uri> ImageUris => new List<Uri>
        {
            new Uri(),
            new Uri()
        };

        public IList<Category> Categories => new List<Category>
        {
            Category.WALKTHROUGHS, Category.PHOTOS
        };
    }
}
