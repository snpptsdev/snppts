using System;
using System.Collections.Generic;
using Snppts.Authors;
using Snppts.Extensions;
using Snppts.Infrastructure;

namespace Snppts.Snippets
{
    public class IntroductionPage : IAmASnippet
    {
        public string Slug => "introduction-page";
        public string Title => "Introduction Page";
        public GitHubRepoInfo GitHubRepoInfo => new GitHubRepoInfo("CrossGeeks/Xamarin.Samples");
        public bool ContainsAndroidSample => true;
        public bool ContainsiOSSample => true;
        public bool ContainsUWPSample => false;

        public string Description => "Simple and beautiful introduction Page.";

        public IAmAnAuthor AuthorInfo => new CharlinAgramonte();

        public IEnumerable<Uri> ImageUris => new List<Uri>
        {
            new Uri("https://raw.githubusercontent.com/snpptsdev/MigratedImages/master/61/108.jpg"),
            new Uri("https://raw.githubusercontent.com/snpptsdev/MigratedImages/master/61/109.jpg")
        };

        public IList<Category> Categories => new List<Category>
        {
            Category.LAUNCHSCREEN
        };

        public Uri ExternalUri => new Uri("https://xamgirl.com/cool-introduction-page-using-xamarin-forms");
    }
}
