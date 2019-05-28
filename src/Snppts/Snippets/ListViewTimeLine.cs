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

        public string Description => "A simple timeline implementation using ListViews with ViewCells, Headers and Footers. But the effect is nice ;-) Blog article that walks through the design: <a href=\"https://www.kymphillpotts.com/xamarin-forms-layout-challenges-timeline/\" target=\"_blank\">https://www.kymphillpotts.com/xamarin-forms-layout-challenges-timeline/</a>";

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
    }
}
