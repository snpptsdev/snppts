using System;
using System.Collections.Generic;
using Snppts.Authors;
using Snppts.Infrastructure;

namespace Snppts.Snippets
{
    public class RunAway : IAmASnippet
    {
        public string Slug => "RunAway!";
        public string Title => "RunAway!";
        public string GithubRepoName => "roubachof/SkiaSharpnado";
        public bool ContainsAndroidSample => true;
        public bool ContainsiOSSample => true;
        public bool ContainsUWPSample => true;

        public string Description => "Something like a Xamarin.Forms Runtastic-like training sessions viewer, displaying gradient lines on top of Google Maps with SkiaSharp";

        public IAmAnAuthor AuthorInfo => new JeanMarieAlfonsi();

        public IEnumerable<Uri> ImageUris => new List<Uri>
        {
            new Uri("https://raw.githubusercontent.com/roubachof/SkiaSharpnado/master/__Docs__/activity_page_android_4dp.png"),
            new Uri("https://raw.githubusercontent.com/roubachof/SkiaSharpnado/master/__Docs__/activity_header_page_ios.png"),
            new Uri("https://raw.githubusercontent.com/roubachof/SkiaSharpnado/master/__Docs__/activity_page_ios_4dp.png"),
            new Uri("https://raw.githubusercontent.com/roubachof/SkiaSharpnado/master/__Docs__/glenn_thick.png")
        };

        public IList<Category> Categories => new List<Category>
        {
            Category.MAPS, Category.CARDS
        };

        public Uri ExternalUri => new Uri("https://www.sharpnado.com/run-away-app/");
    }
}
