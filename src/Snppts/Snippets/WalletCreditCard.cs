using Snppts.Authors;
using Snppts.Extensions;
using Snppts.Infrastructure;
using System;
using System.Collections.Generic;

namespace Snppts.Snippets
{
    public class WalletCreditCard : IAmASnippet
    {
        public string Slug => "xamarinforms-wallet-creditcard";
        public string Title => "XanarinForms Wallet Credit Card";
        public string Description => "Concept of Wallet Credit Card App developed with Xamarin.Forms.";
        public GitHubRepoInfo GitHubRepoInfo => new GitHubRepoInfo("Altevir/xamarinforms-wallet-creditcard");
        public Uri ExternalUri => null;
        public bool ContainsAndroidSample => true;
        public bool ContainsiOSSample => true;
        public bool ContainsUWPSample => false;
        public Sdk BuiltWith => Sdk.XamarinForms;
        public IAmAnAuthor AuthorInfo => new AltevirCardosoNeto();

        public IEnumerable<Uri> ImageUris => new List<Uri>
        {
            new Uri("https://user-images.githubusercontent.com/11803107/80869536-8ba40300-8c77-11ea-975f-1f90b0973430.jpg"),
            new Uri("https://user-images.githubusercontent.com/11803107/80869544-9494d480-8c77-11ea-93f6-4a1f4449ee8c.jpg"),
            new Uri("https://user-images.githubusercontent.com/11803107/80869565-9eb6d300-8c77-11ea-9ff8-6894ba0dd743.JPG"),
            new Uri("https://user-images.githubusercontent.com/11803107/80869572-a8403b00-8c77-11ea-88ab-cdc322b4f738.JPG"),
            new Uri("https://user-images.githubusercontent.com/11803107/80870446-daa06700-8c7c-11ea-8d7a-2487b95b01a7.gif")
        };

        public IList<Category> Categories => new List<Category>
        {
            Category.LISTS,
            Category.PHOTOS,
            Category.CARDS,
            Category.SEARCH,
            Category.STORES
        };
    }
}
