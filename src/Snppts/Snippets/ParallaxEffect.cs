using System;
using System.Collections.Generic;
using Snppts.Authors;
using Snppts.Extensions;
using Snppts.Infrastructure;

namespace Snppts.Snippets
{
    public class ParallaxEffect : IAmASnippet
    {
        public string Slug => "Parallax-Effect";
        public string Title => "Parallax Effect";
        public string GithubRepoName => "ValonK/Xamarin.Forms.Parallax";
        public bool ContainsAndroidSample => true;
        public bool ContainsiOSSample => true;
        public bool ContainsUWPSample => false;
        public Sdk BuiltWith => Sdk.XamarinForms;

        public string Description => "The device's orientation sensor is used to create the parallax effect.";

        public IAmAnAuthor AuthorInfo => new ValonK();

        public IEnumerable<Uri> ImageUris => new List<Uri>
        {
            new Uri("https://github.com/ValonK/Xamarin.Forms.Parallax/raw/main/assets/showcase.gif?raw=true"),
        };

        public IList<Category> Categories => new List<Category>
        {
            Category.CARDS,
            Category.CAROUSEL
        };

        public GitHubRepoInfo GitHubRepoInfo => new GitHubRepoInfo("ValonK/Xamarin.Forms.Parallax")
        {
            Description = "The device's orientation sensor is used to create the parallax effect.",
            FullName = "Xamarin.Forms.Parallax",
        };

        public Uri ExternalUri => new Uri("https://github.com/ValonK/Xamarin.Forms.Parallax");
    }
}