using System;
using System.Collections.Generic;
using Snppts.Authors;
using Snppts.Extensions;
using Snppts.Infrastructure;

namespace Snppts.Snippets
{
    public class MarvelCards : IAmASnippet
    {
        public string Slug => "marvel-cards";
        public string Title => "Marvel Cards";
        public GitHubRepoInfo GitHubRepoInfo => new GitHubRepoInfo("kphillpotts/MarvelCards");
        public bool ContainsAndroidSample => true;
        public bool ContainsiOSSample => true;
        public bool ContainsUWPSample => false;

        public string Description => "A swiping card UI with loads of animations with Skia Sharp.";

        public IAmAnAuthor AuthorInfo => new KymPhillpotts();

        public IEnumerable<Uri> ImageUris => new List<Uri>
        {
            new Uri("https://raw.githubusercontent.com/kphillpotts/MarvelCards/master/design/Screenshot_1565521630.png"),
        };

        public IList<Category> Categories => new List<Category>
        {
            Category.CARDS, Category.LISTS, Category.POPOVERS, Category.NAVIGATIONS, 
        };

        public Uri ExternalUri => null;
    }
}
