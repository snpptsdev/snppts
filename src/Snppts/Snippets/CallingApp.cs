using Snppts.Authors;
using Snppts.Extensions;
using Snppts.Infrastructure;
using System;
using System.Collections.Generic;

namespace Snppts.Snippets
{
    public class CallingApp : IAmASnippet
    {
        public string Slug => "calling-app";
        public string Title => "Calling App";
        public string Description => "A Xamarin.Forms application based on majority wallet & calling design by Hampus Öhman from Dribbble.com.";
        public GitHubRepoInfo GitHubRepoInfo => new GitHubRepoInfo("RadekVyM/Calling-App");
        public Uri ExternalUri => null;
        public bool ContainsAndroidSample => true;
        public bool ContainsiOSSample => true;
        public bool ContainsUWPSample => false;
        public Sdk BuiltWith => Sdk.XamarinForms;
        public IAmAnAuthor AuthorInfo => new RadekVymetalik();

        public IEnumerable<Uri> ImageUris => new List<Uri>
        {
            new Uri("https://raw.githubusercontent.com/RadekVyM/Calling-App/main/Images/callingapp.gif"),
            new Uri("https://raw.githubusercontent.com/RadekVyM/Calling-App/main/Images/callingapp2.gif")
        };

        public IList<Category> Categories => new List<Category>
        {
            Category.LISTS,
            Category.CARDS,
            Category.NAVIGATIONS
        };
    }
}
