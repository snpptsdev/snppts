using System;
using System.Collections.Generic;
using Snppts.Authors;
using Snppts.Extensions;
using Snppts.Infrastructure;

namespace Snppts.Snippets
{
    public class WelcomePage : IAmASnippet
    {
        public string Slug => "welcome-page";
        public string Title => "Welcome Page";
        public string Description => "Example of a welcome page with Xamarin.Forms.";

        public GitHubRepoInfo GitHubRepoInfo => new GitHubRepoInfo("TBertuzzi/PaginaIIntroducaoExemplo");

        public bool ContainsAndroidSample => true;
        public bool ContainsiOSSample => true;
        public bool ContainsUWPSample => false;

        public IAmAnAuthor AuthorInfo => new ThiagoBertuzzi();

        public IEnumerable<Uri> ImageUris => new List<Uri>
        {
            new Uri("https://raw.githubusercontent.com/snpptsdev/MigratedImages/master/147/176.jpg"),
            new Uri("https://raw.githubusercontent.com/snpptsdev/MigratedImages/master/147/177.jpg")
        };

        public IList<Category> Categories => new List<Category>
        {
            Category.LOGIN
        };

        public Uri ExternalUri => null;
    }
}
