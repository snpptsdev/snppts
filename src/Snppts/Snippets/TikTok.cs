using System;
using System.Collections.Generic;
using Snppts.Authors;
using Snppts.Extensions;
using Snppts.Infrastructure;

namespace Snppts.Snippets
{
    public class TikTok : IAmASnippet
    {
        public string Slug => "tiktok";
        public string Title => "TikTok Clone";
        public string GithubRepoName => "ValonK/Xamarin.Forms.TikTok";
        public bool ContainsAndroidSample => true;
        public bool ContainsiOSSample => false;
        public bool ContainsUWPSample => false;

        public string Description => "TikTok clone build with Xamarin.Forms.";

        public IAmAnAuthor AuthorInfo => new ValonK();

        public IEnumerable<Uri> ImageUris => new List<Uri>
        {
            new Uri("https://github.com/ValonK/Xamarin.Forms.TikTok/raw/main/assets/1.jpg?raw=true"),
            new Uri("https://github.com/ValonK/Xamarin.Forms.TikTok/raw/main/assets/2.jpg?raw=true")
        };

        public IList<Category> Categories => new List<Category>
        {
            Category.LOGIN
        };

        public GitHubRepoInfo GitHubRepoInfo => new GitHubRepoInfo("ValonK/Xamarin.Forms.TikTok")
        {
            Description = "TikTok clone build with Xamarin.Forms.",
            FullName = "Xamarin.Forms.TikTok",
        };

        public Uri ExternalUri => new Uri("https://github.com/ValonK/Xamarin.Forms.TikTok");
    }
}
