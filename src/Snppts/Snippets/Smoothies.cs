using System;
using System.Collections.Generic;
using Snppts.Authors;
using Snppts.Infrastructure;

namespace Snppts.Snippets
{
    public class Smoothies : IAmASnippet
    {
        public string Slug => "smoothies";
        public string Title => "Smoothies";
        public string GithubRepoName => "sthewissen/KickassUI.Runkeeper";
        public bool ContainsAndroidSample => true;
        public bool ContainsiOSSample => true;
        public bool ContainsUWPSample => false;

        public string Description => "Recently we've seen an increase in the amount of smoothies created at the office. Apparently they are the hype object of the month. So without further ado we bring you a sample product overview of smoothies. Yuk! This uses a simple hamburger menu (to counter the health level of these smoothies), a search bar and some custom fonts.";

        public IAmAnAuthor AuthorInfo => new StevenThewissen();

        public IEnumerable<Uri> ImageUris => new List<Uri>
        {
            new Uri("https://raw.githubusercontent.com/snpptsdev/MigratedImages/master/28/71.jpg"),
            new Uri("https://raw.githubusercontent.com/snpptsdev/MigratedImages/master/28/72.jpg")
        };

        public IList<Category> Categories => new List<Category>
        {
            Category.CARDS, Category.LISTS, Category.PRODUCTS
        };
    }
}
