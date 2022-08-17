using Snppts.Authors;
using Snppts.Extensions;
using Snppts.Infrastructure;
using System;
using System.Collections.Generic;

namespace Snppts.Snippets
{
    public class WasteApp : IAmASnippet
    {
        public string Slug => "waste-app";
        public string Title => "Waste App";
        public string Description => "A Xamarin.Forms application based on Waste App design by Sara Salehi from Dribbble.com.";
        public GitHubRepoInfo GitHubRepoInfo => new GitHubRepoInfo("RadekVyM/Waste-App");
        public Uri ExternalUri => null;
        public bool ContainsAndroidSample => true;
        public bool ContainsiOSSample => false;
        public bool ContainsUWPSample => false;
        public Sdk BuiltWith => Sdk.XamarinForms;
        public IAmAnAuthor AuthorInfo => new RadekVymetalik();

        public IEnumerable<Uri> ImageUris => new List<Uri>
        {
            new Uri("https://raw.githubusercontent.com/RadekVyM/Waste-App/main/Images/homepage.gif"),
            new Uri("https://raw.githubusercontent.com/RadekVyM/Waste-App/main/Images/scan.jpg"),
            new Uri("https://raw.githubusercontent.com/RadekVyM/Waste-App/main/Images/detailpage.jpg"),
        };

        public IList<Category> Categories => new List<Category>
        {
            Category.LISTS,
            Category.CARDS,
            Category.NAVIGATIONS,
            Category.PHOTOS
        };
    }
}
