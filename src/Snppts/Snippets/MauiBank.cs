using Snppts.Authors;
using Snppts.Infrastructure;
using System.Collections.Generic;
using System;
using Snppts.Extensions;

namespace Snppts.Snippets
{
    public class MauiBank : IAmASnippet
    {
        public string Slug => "dotnet-maui-bank";
        public string Title => ".NET MAUI Bank app";
        public string GithubRepoName => "VladislavAntonyuk/MauiSamples";
        public bool ContainsAndroidSample => true;
        public bool ContainsiOSSample => true;
        public bool ContainsUWPSample => true;

        public string Description => "Replicate Monobank design.";

        public IAmAnAuthor AuthorInfo => new VladislavAntonyuk();

        public IEnumerable<Uri> ImageUris => new List<Uri>
        {
            new Uri("https://vladislavantonyuk.sirv.com/vladislavantonyuk/articles/dotnet-maui-bank.svg"),
            new Uri("https://vladislavantonyuk.sirv.com/vladislavantonyuk/articles/dotnet-maui-bank-app.gif")

        };

        public IList<Category> Categories => new List<Category>
        {
            Category.APPCLONE, Category.CARDS, Category.LOGIN, Category.SHOPPINGCART
        };

        public GitHubRepoInfo GitHubRepoInfo => new GitHubRepoInfo("VladislavAntonyuk/MauiBank");

        public Uri ExternalUri => null;
    }
}
