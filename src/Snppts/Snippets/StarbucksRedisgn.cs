using System;
using System.Collections.Generic;
using Snppts.Authors;
using Snppts.Extensions;
using Snppts.Infrastructure;

namespace Snppts.Snippets
{
    public class StarbucksRedisgn : IAmASnippet
    {
        public string Slug => "maui-starbucks-redesign";
        public string Title => "Maui Starbuck Redesign";
        public GitHubRepoInfo GitHubRepoInfo => new GitHubRepoInfo("sattasundar/maui-starbucks-ui");
        public bool ContainsAndroidSample => true;
        public bool ContainsiOSSample => false;
        public bool ContainsUWPSample => false;

        public string Description => "StarbucksRedesign App UI build in all new .NET MAUI ";

        public IAmAnAuthor AuthorInfo => new SattaSundar();

        public IEnumerable<Uri> ImageUris => new List<Uri>
        {
            new Uri("https://raw.githubusercontent.com/sattasundar/maui-starbucks-ui/main/images/android_home.png"),
            new Uri("https://raw.githubusercontent.com/sattasundar/maui-starbucks-ui/blob/main/images/android_detail.png"),
            new Uri("https://raw.githubusercontent.com/sattasundar/maui-starbucks-ui/blob/main/images/android_splash.png"),
        };

        public IList<Category> Categories => new List<Category>
        {
            Category.PRODUCTS
        };

        public Uri ExternalUri => new Uri("https://github.com/sattasundar/maui-starbucks-ui");
    }
}