using Snppts.Authors;
using Snppts.Extensions;
using Snppts.Infrastructure;
using System;
using System.Collections.Generic;

namespace Snppts.Snippets
{
    public class InstagramRedesignApp : IAmASnippet
    {
        public string Slug => "instagram-redesign-app";
        public string Title => "Instagram Redesign";
        public string Description => "The Xamarin.Forms application based on Instagram Redesign by Manuel Rovira from Dribbble.com.";
        public GitHubRepoInfo GitHubRepoInfo => new GitHubRepoInfo("RadekVyM/Instagram-Redesign-App");
        public Uri ExternalUri => null;
        public bool ContainsAndroidSample => true;
        public bool ContainsiOSSample => false;
        public bool ContainsUWPSample => false;
        public IAmAnAuthor AuthorInfo => new RadekVymetalik();

        public IEnumerable<Uri> ImageUris => new List<Uri>
        {
            new Uri("https://raw.githubusercontent.com/RadekVyM/Instagram-Redesign-App/main/Images/detailpage%20light.gif"),
            new Uri("https://raw.githubusercontent.com/RadekVyM/Instagram-Redesign-App/main/Images/homepage.gif"),
            new Uri("https://raw.githubusercontent.com/RadekVyM/Instagram-Redesign-App/main/Images/profilepage.gif"),
            new Uri("https://raw.githubusercontent.com/RadekVyM/Instagram-Redesign-App/main/Images/profilepage2%20dark.jpg"),
            new Uri("https://raw.githubusercontent.com/RadekVyM/Instagram-Redesign-App/main/Images/activitypage%20dark.jpg"),
            new Uri("https://raw.githubusercontent.com/RadekVyM/Instagram-Redesign-App/main/Images/homepage%20dark.jpg")
        };

        public IList<Category> Categories => new List<Category>
        {
            Category.LISTS,
            Category.NAVIGATIONS,
            Category.CAROUSEL,
            Category.COMMENTS,
            Category.PHOTOS,
            Category.POPOVERS,
            Category.PROFILES,
            Category.SETTINGS
        };
    }
}
