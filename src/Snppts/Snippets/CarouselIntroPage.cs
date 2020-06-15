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

        public GitHubRepoInfo GitHubRepoInfo => new GitHubRepoInfo("LucioMSP/Xamarin.Forms.Examples/tree/master/CarouselIntroPage");

        public bool ContainsAndroidSample => true;
        public bool ContainsiOSSample => true;
        public bool ContainsUWPSample => false;

        public string Description => "Simple example of an introductory page in Xamarin.Forms.";

        public IAmAnAuthor AuthorInfo => new VicenteGuzman();

        public IEnumerable<Uri> ImageUris => new List<Uri>
        {
            new Uri("https://github.com/LucioMSP/Xamarin.Forms.Examples/blob/master/CarouselIntroPage/ScreenShots/ScreenShot01.png"),
            new Uri("https://github.com/LucioMSP/Xamarin.Forms.Examples/blob/master/CarouselIntroPage/ScreenShots/ScreenShot02.png"),
            new Uri("https://github.com/LucioMSP/Xamarin.Forms.Examples/blob/master/CarouselIntroPage/ScreenShots/ScreenShot03.png"),
        };

        public IList<Category> Categories => new List<Category>
        {
            Category.LOGIN
        };

        public Uri ExternalUri => null;
    }
}
