using Snppts.Authors;
using Snppts.Extensions;
using Snppts.Infrastructure;
using System;
using System.Collections.Generic;

namespace Snppts.Snippets
{
    public class SalonMobile : IAmASnippet
    {
        public string Slug => "salon-mobile";
        public string Title => "Salon Mobile";
        public GitHubRepoInfo GitHubRepoInfo => new GitHubRepoInfo("kainaalmeida/SalonMobile");
        public bool ContainsAndroidSample => true;
        public bool ContainsiOSSample => true;
        public bool ContainsUWPSample => false;
        public Sdk BuiltWith => Sdk.XamarinForms;

        public string Description => "This snippet was created to demonstrate some animations";

        public IAmAnAuthor AuthorInfo => new KainaAlmeida();

        public IEnumerable<Uri> ImageUris => new List<Uri>
        {
            new Uri("https://raw.githubusercontent.com/kainaalmeida/SalonMobile/master/screenshots/iOS01.png"),
            new Uri("https://raw.githubusercontent.com/kainaalmeida/SalonMobile/master/screenshots/iOS02.png"),
            new Uri("https://raw.githubusercontent.com/kainaalmeida/SalonMobile/master/screenshots/droid01.jpg"),
            new Uri("https://raw.githubusercontent.com/kainaalmeida/SalonMobile/master/screenshots/droid02.jpg")
        };

        public IList<Category> Categories => new List<Category>
        {
            Category.LISTS,
            Category.PHOTOS
        };

        public Uri ExternalUri => null;
    }
}
