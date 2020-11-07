using Snppts.Authors;
using Snppts.Extensions;
using Snppts.Infrastructure;
using System;
using System.Collections.Generic;

namespace Snppts.Snippets
{
    public class MovieApp : IAmASnippet
    {
        public string Slug => "movie-app";
        public string Title => "Movie App";
        public string Description => "A Xamarin.Forms application based on Movie App - MVP design by Lukáš Straňák and Barbora Sojakova from Dribbble.com.";
        public GitHubRepoInfo GitHubRepoInfo => new GitHubRepoInfo("RadekVyM/Movie-App");
        public Uri ExternalUri => null;
        public bool ContainsAndroidSample => true;
        public bool ContainsiOSSample => false;
        public bool ContainsUWPSample => false;
        public IAmAnAuthor AuthorInfo => new RadekVymetalik();

        public IEnumerable<Uri> ImageUris => new List<Uri>
        {
            new Uri("https://raw.githubusercontent.com/RadekVyM/Movie-App/main/Images/detailpageThor.gif"),
            new Uri("https://raw.githubusercontent.com/RadekVyM/Movie-App/main/Images/mainpage.gif"),
            new Uri("https://raw.githubusercontent.com/RadekVyM/Movie-App/main/Images/ironman.jpg"),
            new Uri("https://raw.githubusercontent.com/RadekVyM/Movie-App/main/Images/detailpageIronman.jpg"),
            new Uri("https://raw.githubusercontent.com/RadekVyM/Movie-App/main/Images/drstrange.jpg")
        };

        public IList<Category> Categories => new List<Category>
        {
            Category.LISTS,
            Category.CARDS,
            Category.NAVIGATIONS,
            Category.PHOTOS,
            Category.CAROUSEL
        };
    }
}
