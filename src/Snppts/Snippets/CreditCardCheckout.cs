using Snppts.Authors;
using Snppts.Extensions;
using Snppts.Infrastructure;
using System;
using System.Collections.Generic;

namespace Snppts.Snippets
{
    public class CreditCardCheckout : IAmASnippet
    {
        public string Slug => "credit-card-checkout";
        public string Title => "Credit Card Checkout";
        public GitHubRepoInfo GitHubRepoInfo => new GitHubRepoInfo("egbakou/CreditCardCheckout");
        public bool ContainsAndroidSample => true;
        public bool ContainsiOSSample => true;
        public bool ContainsUWPSample => false;

        public string Description => "A Xamarin.Forms UI Challenge based on a fantastic dribble design.";

        public IAmAnAuthor AuthorInfo => new KodjoLaurentEgbakou();

        public IEnumerable<Uri> ImageUris => new List<Uri>
        {
            new Uri("https://raw.githubusercontent.com/egbakou/CreditCardCheckout/master/design/Screenshot_20191105-112705.png"),
            new Uri("https://raw.githubusercontent.com/egbakou/CreditCardCheckout/master/design/Screenshot_20191105-112636.png")
        };

        public IList<Category> Categories => new List<Category>
        {
            Category.CARDS, Category.TIMELINE, Category.SHOPPINGCART
        };

        public Uri ExternalUri => new Uri("https://lioncoding.com/2019/11/05/2019-11-05-Credit-Card-checkout-CarouselView-de-Xamarin-forms-4-3-en-action/");
    }
}
