using System;
using System.Collections.Generic;
using Snppts.Authors;
using Snppts.Infrastructure;

namespace Snppts.Snippets
{
    public class NetflixClone : IAmASnippet
    {
        public string Slug => "netflix-clone";
        public string Title => "Netflix Clone";
        public string GithubRepoName => "jsuarezruiz/xamarin-forms-netflix-sample";
        public bool ContainsAndroidSample => true;
        public bool ContainsiOSSample => true;
        public bool ContainsUWPSample => false;

        public string Description => "A Xamarin.Forms version of the Netflix App to prove you can create goodlooking UI with Xamarin.Forms.";

        public IAmAnAuthor AuthorInfo => new JavierSuarezRuiz();

        public IEnumerable<Uri> ImageUris => new List<Uri>
        {
            new Uri("https://raw.githubusercontent.com/snpptsdev/MigratedImages/master/85/136.jpg"),
            new Uri("https://raw.githubusercontent.com/snpptsdev/MigratedImages/master/85/137.jpg"),
            new Uri("https://raw.githubusercontent.com/snpptsdev/MigratedImages/master/85/138.jpg")
        };

        public IList<Category> Categories => new List<Category>
        {
            Category.LISTS, Category.NAVIGATIONS, Category.WIDGETS
        };
    }
}
