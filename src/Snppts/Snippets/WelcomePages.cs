using System;
using System.Collections.Generic;
using Snppts.Authors;
using Snppts.Extensions;
using Snppts.Infrastructure;

namespace Snppts.Snippets
{
    public class WelcomePages : IAmASnippet
    {
        public string Slug => "welcome-pages";
        public string Title => "Welcome Pages";

        public GitHubRepoInfo GitHubRepoInfo => new GitHubRepoInfo("leroygumede/WelcomeCarousel");

        public bool ContainsAndroidSample => true;
        public bool ContainsiOSSample => true;
        public bool ContainsUWPSample => false;

        public string Description => "Template app with a few unused Welcome Pages. I'm also using Carousel on a few pages. And yes the text is slidable.";

        public IAmAnAuthor AuthorInfo => new LeRoyGumede();

        public IEnumerable<Uri> ImageUris => new List<Uri>
        {
            new Uri("https://raw.githubusercontent.com/snpptsdev/MigratedImages/master/103/143.jpg"),
            new Uri("https://raw.githubusercontent.com/snpptsdev/MigratedImages/master/103/144.jpg"),
            new Uri("https://raw.githubusercontent.com/snpptsdev/MigratedImages/master/103/145.jpg"),
            new Uri("https://raw.githubusercontent.com/snpptsdev/MigratedImages/master/103/146.jpg"),
            new Uri("https://raw.githubusercontent.com/snpptsdev/MigratedImages/master/103/147.jpg"),
            new Uri("https://raw.githubusercontent.com/snpptsdev/MigratedImages/master/103/148.jpg"),
            new Uri("https://raw.githubusercontent.com/snpptsdev/MigratedImages/master/103/149.jpg"),
            new Uri("https://raw.githubusercontent.com/snpptsdev/MigratedImages/master/103/150.jpg"),
        };

        public IList<Category> Categories => new List<Category>
        {
            Category.WALKTHROUGHS
        };

        public Uri ExternalUri => null;
    }
}
