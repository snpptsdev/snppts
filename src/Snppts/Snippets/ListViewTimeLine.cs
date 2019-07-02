using System;
using System.Collections.Generic;
using Snppts.Authors;
using Snppts.Infrastructure;

namespace Snppts.Snippets
{
    public class ListViewTimeLine : IAmASnippet
    {
        public string Slug => "listview-timeline";
        public string Title => "ListView TimeLine";
        public string GithubRepoName => "kphillpotts/XamarinFormsLayoutChallenges";
        public bool ContainsAndroidSample => true;
        public bool ContainsiOSSample => true;
        public bool ContainsUWPSample => false;

        public string Description => "A simple timeline implementation using ListViews with ViewCells, Headers and Footers. But the effect is nice ;-)";

        public IAmAnAuthor AuthorInfo => new KymPhillpotts();

        public IEnumerable<Uri> ImageUris => new List<Uri>
        {
            new Uri("https://raw.githubusercontent.com/snpptsdev/MigratedImages/master/79/130.jpg"),
            new Uri("https://raw.githubusercontent.com/snpptsdev/MigratedImages/master/79/131.jpg")
        };

        public IList<Category> Categories => new List<Category>
        {
            Category.TIMELINE, Category.ACTIVITYFEEDS, Category.LISTS
        };

        public Uri ExternalUri => new Uri("https://kymphillpotts.com/xamarin-forms-layout-challenges-timeline");
    }
}
