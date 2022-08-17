using Snppts.Authors;
using Snppts.Extensions;
using Snppts.Infrastructure;
using System;
using System.Collections.Generic;

namespace Snppts.Snippets
{
    public class SimpleRatingControlMaui : IAmASnippet
    {
        public string Slug => "simple-rating-control-maui";

        public string Title => "Simple Rating Control for .NET MAUI";

        public string Description => "Custom control for .NET MAUI showing a rating using an icon font.";

        public GitHubRepoInfo GitHubRepoInfo => new GitHubRepoInfo("tsjdev-apps/simpleratingcontrol.maui");

        public Uri ExternalUri => new Uri("https://github.com/tsjdev-apps/simpleratingcontrol.maui");

        public bool ContainsAndroidSample => true;

        public bool ContainsiOSSample => true;

        public bool ContainsUWPSample => true;
        
        public Sdk BuiltWith => Sdk.Maui;

        public IAmAnAuthor AuthorInfo => new SebastianJensen();

        public IEnumerable<Uri> ImageUris => new List<Uri>
        {
            new Uri("https://raw.githubusercontent.com/tsjdev-apps/simpleratingcontrol.maui/main/docs/sample-android.png"),
            new Uri("https://raw.githubusercontent.com/tsjdev-apps/simpleratingcontrol.maui/main/docs/sample-windows.png"),
        };

        public IList<Category> Categories => new List<Category> { Category.WIDGETS, Category.CHARTS };
    }
}
