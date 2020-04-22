using System;
using System.Collections.Generic;
using Snppts.Authors;
using Snppts.Extensions;
using Snppts.Infrastructure;

namespace Snppts.Snippets
{
    public class SocialNetwork : IAmASnippet
    {
        public string Slug => "social-network";
        public string Title => "Social Network";

        public GitHubRepoInfo GitHubRepoInfo => new GitHubRepoInfo("kphillpotts/XamarinFormsLayoutChallenges/tree/master/SocialNetwork");

        public bool ContainsAndroidSample => true;
        public bool ContainsiOSSample => true;
        public bool ContainsUWPSample => true;

        public string Description => "A simple Social Network profile type page in Xamarin.Forms.";

        public IAmAnAuthor AuthorInfo => new KymPhillpotts();

        public IEnumerable<Uri> ImageUris => new List<Uri>
        {
            new Uri("https://raw.githubusercontent.com/kphillpotts/XamarinFormsLayoutChallenges/master/SocialNetwork/Screenshots/iPhone6-33.png")
        };

        public IList<Category> Categories => new List<Category>
        {
            Category.PHOTOS, Category.ABOUT, Category.FRIENDS
        };

        public Uri ExternalUri => new Uri("https://kymphillpotts.com/social-network-app-layout-design-in-xamarin-forms");
    }
}
