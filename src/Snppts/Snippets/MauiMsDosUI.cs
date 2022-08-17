using Snppts.Authors;
using Snppts.Infrastructure;
using System.Collections.Generic;
using System;
using Snppts.Extensions;

namespace Snppts.Snippets
{
    public class MauiMsDosUI : IAmASnippet
    {
        public string Slug => "maui-ms-dos";
        public string Title => "Maui MS Dos";
        public string GithubRepoName => "jm-parent/MSDos4Ever";
        public bool ContainsAndroidSample => true;
        public bool ContainsiOSSample => true;
        public bool ContainsUWPSample => true;
        public Sdk BuiltWith => Sdk.Maui;

        public string Description => "For all developers who want to make an application with a modern and clean design.";

        public IAmAnAuthor AuthorInfo => new JeanMarieParent();

        public IEnumerable<Uri> ImageUris => new List<Uri>
        {
            //Mobile
            new Uri("https://github.com/jm-parent/MSDos4Ever/blob/master/MSDos4Ever/SnpptsImages/msdos_ios_portrait.png?raw=true"),
            new Uri("https://github.com/jm-parent/MSDos4Ever/blob/master/MSDos4Ever/SnpptsImages/msdos_ios_landscape.png?raw=true"),
            //Windows
            new Uri("https://github.com/jm-parent/MSDos4Ever/blob/master/MSDos4Ever/SnpptsImages/msdos_windows.png?raw=true")

        };

        public IList<Category> Categories => new List<Category>
        {
            Category.LAUNCHSCREEN,Category.CARDS
        };

        public GitHubRepoInfo GitHubRepoInfo => new GitHubRepoInfo("jm-parent/MSDos4Ever");

        public Uri ExternalUri => null;
    }
}
