using System;
using System.Collections.Generic;
using Snppts.Authors;
using Snppts.Extensions;
using Snppts.Infrastructure;

namespace Snppts.Snippets
{
    public class CarouselIntroPage : IAmASnippet
    {
        public string Slug => "carousel-intro-page";
        public string Title => "Carousel Intro Page";

        public GitHubRepoInfo GitHubRepoInfo => new GitHubRepoInfo("LucioMSP/CarouselIntroPage");

        public bool ContainsAndroidSample => true;
        public bool ContainsiOSSample => true;
        public bool ContainsUWPSample => false;

        public string Description => "Simple example of an introductory page in Xamarin.Forms.";

        public IAmAnAuthor AuthorInfo => new VicenteGuzman();

        public IEnumerable<Uri> ImageUris => new List<Uri>
        {
            new Uri("https://raw.githubusercontent.com/luciomsp/CarouselIntroPage/master/ScreenShots/ScreenShot01.png"),
            new Uri("https://raw.githubusercontent.com/luciomsp/CarouselIntroPage/master/103/ScreenShot02.png"),
            new Uri("https://raw.githubusercontent.com/luciomsp/CarouselIntroPage/master/103/ScreenShot03.png"),
        }

        public IList<Category> Categories => new List<Category>
        {
            Category.LOGIN
        };

        public Uri ExternalUri => null;
    }
}
