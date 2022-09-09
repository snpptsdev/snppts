using Snppts.Authors;
using Snppts.Extensions;
using Snppts.Infrastructure;
using System;
using System.Collections.Generic;

namespace Snppts.Snippets
{
    public class BoomerangCardMaui : IAmASnippet
    {
        public string Slug => "maui-matching-game";
        public string Title => "Maui Matching Game";
        public GitHubRepoInfo GitHubRepoInfo => new GitHubRepoInfo("shawyunz/matching.maui");
        public Uri ExternalUri => null;
        public bool ContainsAndroidSample => true;
        public bool ContainsiOSSample => true;
        public bool ContainsUWPSample => false;
        public bool ContainsmacOSSample => false;
        public Sdk BuiltWith => Sdk.Maui;

        public string Description => "A simple memory card (match up) game in .Net Maui.";

        public IAmAnAuthor AuthorInfo => new ShawYu();

        public IEnumerable<Uri> ImageUris => new List<Uri>
        {
            new Uri("https://github.com/shawyunz/Matching.Maui/blob/master/demo/demo.gif?raw=true")
        };

        public IList<Category> Categories => new List<Category>
        {
            Category.ANIMATION, Category.CARDS, Category.WIDGETS
        };
    }
}
