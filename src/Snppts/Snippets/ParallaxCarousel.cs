using System;
using System.Collections.Generic;
using Snppts.Authors;
using Snppts.Infrastructure;

namespace Snppts.Snippets
{
    public class ParallaxCarousel : IAmASnippet
    {
        public string Slug => "parallax-carousel";
        public string Title => "Parallax Carousel";
        public string GithubRepoName => "sthewissen/KickassUI.ParallaxCarousel";
        public bool ContainsAndroidSample => true;
        public bool ContainsiOSSample => true;
        public bool ContainsUWPSample => false;

        public string Description => "A Xamarin.Forms version of a parallax carousel to prove you can create goodlooking UI with Xamarin.Forms as talked about in my blogpost on: <a href=\"https://www.thewissen.io/creating-a-parallax-carousel-in-xamarin-forms\" target=\"_blank\">https://www.thewissen.io/creating-a-parallax-carousel-in-xamarin-forms</a>";

        public IAmAnAuthor AuthorInfo => new StevenThewissen();

        public IEnumerable<Uri> ImageUris => new List<Uri>
        {
            new Uri(),
            new Uri(),
            new Uri(),
            new Uri()
        };

        public IList<Category> Categories => new List<Category>
        {
            Category.WALKTHROUGHS, Category.CARDS
        };
    }
}
