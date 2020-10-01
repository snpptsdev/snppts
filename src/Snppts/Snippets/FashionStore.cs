using Snppts.Authors;
using Snppts.Extensions;
using Snppts.Infrastructure;
using System;
using System.Collections.Generic;

namespace Snppts.Snippets
{
    public class FashionStore : IAmASnippet
    {
        public string Slug => "fashion-store-ui";
        public string Title => "Fashion Store UI";
        public GitHubRepoInfo GitHubRepoInfo => new GitHubRepoInfo("valentineg8/FashionStore");
        public bool ContainsAndroidSample => true;
        public bool ContainsiOSSample => true;
        public bool ContainsUWPSample => false;

        public string Description => "A Xamarin.Forms Fashion Store UI.";

        public IAmAnAuthor AuthorInfo => new LorenzoAraujo();

        public IEnumerable<Uri> ImageUris => new List<Uri>
        {
            new Uri("https://raw.githubusercontent.com/valentineg8/FashionStore/master/images/FashionStore.gif?raw=true"),
            new Uri("https://raw.githubusercontent.com/valentineg8/FashionStore/master/images/FasionStoreAndroid.gif?raw=true")
        };

        public IList<Category> Categories => new List<Category>
        {
            Category.STORES, Category.LISTS
        };

        public Uri ExternalUri => null;
    }
}
