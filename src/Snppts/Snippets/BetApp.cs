using Snppts.Authors;
using Snppts.Extensions;
using Snppts.Infrastructure;
using System;
using System.Collections.Generic;

namespace Snppts.Snippets
{
    public class BetApp : IAmASnippet
    {
        public string Slug => "bet-app";
        public string Title => "Bet App";
        public string Description => "A Xamarin.Forms application based on Bet App design by Manoj Rajput from Dribbble.com.";
        public GitHubRepoInfo GitHubRepoInfo => new GitHubRepoInfo("RadekVyM/Bet-App");
        public Uri ExternalUri => null;
        public bool ContainsAndroidSample => true;
        public bool ContainsiOSSample => false;
        public bool ContainsUWPSample => false;
        public IAmAnAuthor AuthorInfo => new RadekVymetalik();

        public IEnumerable<Uri> ImageUris => new List<Uri>
        {
            new Uri("https://raw.githubusercontent.com/RadekVyM/Bet-App/main/Images/betapp.gif"),
            new Uri("https://raw.githubusercontent.com/RadekVyM/Bet-App/main/Images/betapp%20calendar.gif")
        };

        public IList<Category> Categories => new List<Category>
        {
            Category.LISTS,
            Category.CARDS,
            Category.NAVIGATIONS,
            Category.CALENDARSTIME
        };
    }
}
