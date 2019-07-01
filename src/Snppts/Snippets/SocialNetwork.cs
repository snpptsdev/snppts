using System;
using System.Collections.Generic;
using Snppts.Authors;
using Snppts.Infrastructure;

namespace Snppts.Snippets
{
    public class SocialNetwork : IAmASnippet
    {
        public string Slug => "social-network";
        public string Title => "Social Network";
        public string GithubRepoName => "kphillpotts/XamarinFormsLayoutChallenges/tree/master/SocialNetwork";
        public bool ContainsAndroidSample => true;
        public bool ContainsiOSSample => true;
        public bool ContainsUWPSample => true;

        public string Description => "A simple Social Network profile type page in Xamarin.Form. Blog article that walks through the design: <a href=\"https://kymphillpotts.com/social-network-app-layout-design-in-xamarin-forms/\" target=\"_blank\">https://kymphillpotts.com/social-network-app-layout-design-in-xamarin-forms/</a>";

        public IAmAnAuthor AuthorInfo => new KymPhillpotts();

        public IEnumerable<Uri> ImageUris => new List<Uri>
        {
            new Uri("https://github.com/kphillpotts/XamarinFormsLayoutChallenges/blob/master/SocialNetwork/Screenshots/iPhone6-33.png?raw=true")
        };

        public IList<Category> Categories => new List<Category>
        {
            Category.PHOTOS, Category.ABOUT, Category.FRIENDS
        };
    }
}
