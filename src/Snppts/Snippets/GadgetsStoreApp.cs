using Snppts.Authors;
using Snppts.Extensions;
using Snppts.Infrastructure;
using System;
using System.Collections.Generic;

namespace Snppts.Snippets
{
    public class GadgetsStoreApp : IAmASnippet
    {
        public string Slug => "gadgets-store-app";
        public string Title => "Gadgets Store App";
        public string Description => "A Xamarin.Forms application based on Gadgets Store App design by Sajon from Dribbble.com.";
        public GitHubRepoInfo GitHubRepoInfo => new GitHubRepoInfo("RadekVyM/Gadgets-Store-App");
        public Uri ExternalUri => null;
        public bool ContainsAndroidSample => true;
        public bool ContainsiOSSample => false;
        public bool ContainsUWPSample => false;
        public IAmAnAuthor AuthorInfo => new RadekVymetalik();

        public IEnumerable<Uri> ImageUris => new List<Uri>
        {
            new Uri("https://raw.githubusercontent.com/RadekVyM/Gadgets-Store-App/main/Images/flyout-min.gif"),
            new Uri("https://raw.githubusercontent.com/RadekVyM/Gadgets-Store-App/main/Images/home-min.gif"),
            new Uri("https://raw.githubusercontent.com/RadekVyM/Gadgets-Store-App/main/Images/productdetail-min.gif"),
        };

        public IList<Category> Categories => new List<Category>
        {
            Category.LISTS,
            Category.CARDS, 
            Category.NAVIGATIONS,
            Category.PRODUCTS
        };
    }
}
