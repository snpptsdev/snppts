using Snppts.Authors;
using Snppts.Infrastructure;
using System.Collections.Generic;
using System;
using Snppts.Extensions;

namespace Snppts.Snippets
{
    public class BreadcrumbControl : IAmASnippet
    {
        public string Slug => "breadcrumb-control";
        public string Title => "Breadcrumb control";
        public string GithubRepoName => "IeuanWalker/Maui.Breadcrumb";
        public bool ContainsAndroidSample => true;
        public bool ContainsiOSSample => true;
        public bool ContainsUWPSample => false;

        public string Description => "This is a breadcrumb navigation control that is completely automatic and uses the Navigation stack to get the page titles to generate the breadcrumbs.";

        public IAmAnAuthor AuthorInfo => new IeuanWalker();

        public IEnumerable<Uri> ImageUris => new List<Uri>
        {
            new Uri("https://raw.githubusercontent.com/IeuanWalker/Maui.Breadcrumb/master/Example.gif"),
            new Uri("https://raw.githubusercontent.com/IeuanWalker/Maui.Breadcrumb/master/ProdExample.gif")
        };

        public IList<Category> Categories => new List<Category>
        {
            Category.NAVIGATIONS, Category.SIDEBARS
        };

        public GitHubRepoInfo GitHubRepoInfo => new GitHubRepoInfo("IeuanWalker/Maui.Breadcrumb");

        public Uri ExternalUri => null;
    }
}
