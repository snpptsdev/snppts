using System;
using System.Collections.Generic;
using Snppts.Authors;
using Snppts.Extensions;
using Snppts.Infrastructure;

namespace Snppts.Snippets
{
    public class Finance : IAmASnippet
    {
        public string Slug => "maui-finance";
        public string Title => "MAUI Finance";
        public string Description => "Finance mobile application UI built in .NET MAUI.";

        public GitHubRepoInfo GitHubRepoInfo => new GitHubRepoInfo("cemahseri/MauiFinance");
        public Uri ExternalUri => null;

        public bool ContainsAndroidSample => true;
        public bool ContainsiOSSample => true;
        public bool ContainsUWPSample => false;
        public Sdk BuiltWith => Sdk.Maui;

        public IAmAnAuthor AuthorInfo => new YunusEmreAygun();

        public IEnumerable<Uri> ImageUris => new List<Uri>
        {
            new Uri("https://user-images.githubusercontent.com/20908430/183722589-87f62573-7e96-4bd4-bf3e-6cdd4e5ea0f5.png")
        };

        public IList<Category> Categories => new List<Category>
        {
            Category.CARDS,
            Category.DASHBOARD,
            Category.DATAGRID
        };
    }
}