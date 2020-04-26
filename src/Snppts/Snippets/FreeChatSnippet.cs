using Snppts.Authors;
using Snppts.Extensions;
using Snppts.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Snppts.Snippets
{
    public class FreeChatSnippet : IAmASnippet
    {
        public string Slug => "Chat app UI";

        public string Title => "FreeChat";

        public string Description => "User interface demonstrating a pretty chat application";

        public GitHubRepoInfo GitHubRepoInfo => new GitHubRepoInfo("DamienDoumer/freechat");

        public Uri ExternalUri => null;

        public bool ContainsAndroidSample => true;

        public bool ContainsiOSSample => true;

        public bool ContainsUWPSample => false;

        public IAmAnAuthor AuthorInfo => new DamienDoumer();

        public IEnumerable<Uri> ImageUris => new List<Uri>
        {
            new Uri("https://github.com/DamienDoumer/freechat/blob/master/images/freechatAndroidDemo.gif"),
            new Uri("https://github.com/DamienDoumer/freechat/blob/master/images/freechatiOSDemo.gif")
        };

        public IList<Category> Categories => new List<Category>
        {
            Category.MESSAGING,
            Category.SOCIALNETWORK,
            Category.FRIENDS
        };
    }
}
