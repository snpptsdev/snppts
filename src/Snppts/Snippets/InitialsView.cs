using Snppts.Authors;
using Snppts.Extensions;
using Snppts.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Snppts.Snippets
{
    public class InitialsView : IAmASnippet
    {
        public string Slug => "initials-view";

        public string Title => "Initials View";

        public string Description => "Custom control for Android and/or iOS showing the initials of a provided name within a colorful circle.";

        public GitHubRepoInfo GitHubRepoInfo => new GitHubRepoInfo("tsjdev-apps/xf-initialsview");

        public Uri ExternalUri => new Uri("https://medium.com/@tsjdevapps/xamarin-forms-how-to-create-an-intials-view-as-custom-control-for-android-and-ios-e9b09223ed53");

        public bool ContainsAndroidSample => true;

        public bool ContainsiOSSample => true;

        public bool ContainsUWPSample => false;

        public IAmAnAuthor AuthorInfo => new SebastianJensen();

        public IEnumerable<Uri> ImageUris => new List<Uri> { new Uri("https://raw.githubusercontent.com/tsjdev-apps/xf-initialsview/master/Docs/InitialsView.gif") };

        public IList<Category> Categories => new List<Category> { Category.WIDGETS };
    }
}
