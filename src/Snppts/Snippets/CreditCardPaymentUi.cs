using System;
using System.Collections.Generic;
using Snppts.Authors;
using Snppts.Extensions;
using Snppts.Infrastructure;

namespace Snppts.Snippets
{
    public class ParallaxCarousel : IAmASnippet
    {
        public string Slug => "credit-card-payment-ui";
        public string Title => "MAUI Credit Card Payment UI";
        public GitHubRepoInfo GitHubRepoInfo => new GitHubRepoInfo("DamianSuess/Learn.MauiPaymentUi");
        public bool ContainsAndroidSample => true;
        public bool ContainsiOSSample => true;
        public bool ContainsUWPSample => true;

        public string Description => "A sample credit card payment screen written using .NET MAUI and the Prism Library which runs on Windows, Android, iOS and Tizen.";

        public IAmAnAuthor AuthorInfo => new DamianSuess();

        public IEnumerable<Uri> ImageUris => new List<Uri>
        {
            new Uri("https://raw.githubusercontent.com/DamianSuess/Learn.MauiPaymentUi/master/SampleCards.gif"),
        };

        public IList<Category> Categories => new List<Category>
        {
            Category.WALKTHROUGHS, Category.CARDS
        };

        public Uri ExternalUri => new Uri("https://github.com/DamianSuess/Learn.MauiPaymentUi");
    }
}
