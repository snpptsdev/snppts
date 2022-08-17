using System;
using System.Collections.Generic;
using Snppts.Authors;
using Snppts.Extensions;
using Snppts.Infrastructure;

namespace Snppts.Snippets
{
    public class DayVsNight : IAmASnippet
    {
        public string Slug => "day-vs-night";
        public string Title => "Day Vs Night";
        public GitHubRepoInfo GitHubRepoInfo => new GitHubRepoInfo("kphillpotts/DayVsNight");
        public bool ContainsAndroidSample => true;
        public bool ContainsiOSSample => true;
        public bool ContainsUWPSample => false;
        public Sdk BuiltWith => Sdk.XamarinForms;

        public string Description => "Gradients, so many gradients. Skia controls. User selectable themeing.";

        public IAmAnAuthor AuthorInfo => new KymPhillpotts();

        public IEnumerable<Uri> ImageUris => new List<Uri>
        {
            new Uri("https://kymphillpotts.com/assets/images/posts/dayvsnight/day.png"),
            new Uri("https://kymphillpotts.com/assets/images/posts/dayvsnight/night.png")
        };

        public IList<Category> Categories => new List<Category>
        {
            Category.WIDGETS, Category.PROFILES, Category.DASHBOARD
        };

        public Uri ExternalUri => new Uri("https://kymphillpotts.com/xamarin-forms-ui-challenge-dayvsnight.html");
    }
}
