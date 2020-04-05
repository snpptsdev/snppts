using Snppts.Authors;
using Snppts.Extensions;
using Snppts.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Snppts.Snippets
{
    public class SubscriptionPlan : IAmASnippet
    {
        public string Slug => "subscription-plan";

        public string Title => "Subscription Plan";

        public string Description => "A simple subscription plan page";

        public GitHubRepoInfo GitHubRepoInfo => new GitHubRepoInfo("alexandresanlim/XamarinUI.SubscriptionPlan");

        public Uri ExternalUri => null;

        public bool ContainsAndroidSample => true;

        public bool ContainsiOSSample => true;

        public bool ContainsUWPSample => false;

        public IAmAnAuthor AuthorInfo => new AlexandreSanlim();

        public IEnumerable<Uri> ImageUris => new List<Uri>
        {
            new Uri("https://raw.githubusercontent.com/alexandresanlim/SubscriptionPlan.XamarinUI/master/SubscriptionPlan.XamarinUI/SubscriptionPlan.XamarinUI/Screenshots/android.jpg"),
            new Uri("https://raw.githubusercontent.com/alexandresanlim/SubscriptionPlan.XamarinUI/master/SubscriptionPlan.XamarinUI/SubscriptionPlan.XamarinUI/Screenshots/ios.png")
        };

        public IList<Category> Categories => new List<Category>
        { 
            Category.CARDS,
            Category.LISTS
        };
    }
}
