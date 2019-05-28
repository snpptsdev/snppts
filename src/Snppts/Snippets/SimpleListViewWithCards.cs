using System;
using System.Collections.Generic;
using Snppts.Authors;
using Snppts.Infrastructure;

namespace Snppts.Snippets
{
    public class SimpleListViewWithCards : IAmASnippet
    {
        public string Slug => "simple-listview-with-cards";
        public string Title => "Simple ListView with Cards";
        public string GithubRepoName => "sthewissen/KickassUI.Runkeeper";
        public bool ContainsAndroidSample => true;
        public bool ContainsiOSSample => true;
        public bool ContainsUWPSample => false;

        public string Description => "A very simple example demonstrating how to create Cards using Xamarin Forms with Xaml.";

        public IAmAnAuthor AuthorInfo => new WashingtonMorais();

        public IEnumerable<Uri> ImageUris => new List<Uri>
        {
            new Uri("https://raw.githubusercontent.com/snpptsdev/MigratedImages/master/123/151.jpg")
        };

        public IList<Category> Categories => new List<Category>
        {
            Category.CARDS, Category.LISTS
        };
    }
}
