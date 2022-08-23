using Snppts.Authors;
using Snppts.Extensions;
using Snppts.Infrastructure;
using System;
using System.Collections.Generic;

namespace Snppts.Snippets
{
    public class BoomerangCardMaui : IAmASnippet
    {
        public string Slug => "maui-boomerang-card";
        public string Title => "Maui Boomerang Card";
        public GitHubRepoInfo GitHubRepoInfo => new GitHubRepoInfo("shawyunz/BoomerangCard.Maui");
        public bool ContainsAndroidSample => true;
        public bool ContainsiOSSample => true;
        public bool ContainsUWPSample => false;
        public bool ContainsmacOSSample => false;
        public Sdk BuiltWith => Sdk.Maui;

        public string Description => "Boomerang animation in .Net Maui. Inspired by the original Swift UI implementation: https://twitter.com/philipcdavis/status/1534192823792128000";

        public IAmAnAuthor AuthorInfo => new ShawYu();

        public IEnumerable<Uri> ImageUris => new List<Uri>
        {
            new Uri("https://github.com/shawyunz/BoomerangCard.Maui/blob/main/demo/demo.gif")
        };

        public IList<Category> Categories => new List<Category>
        {
            Category.ARTICLES, Category.CARDS, Category.WIDGETS
        };
    }
}
