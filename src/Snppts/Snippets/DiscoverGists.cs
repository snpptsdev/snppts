using Snppts.Authors;
using Snppts.Extensions;
using Snppts.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Snppts.Snippets
{
    public class DiscoverGists : IAmASnippet
    {
        public string Slug => "discover-gists";

        public string Title => "Discover Gists";

        public string Description => "It's a simple discover gists from GitHub app";

        public GitHubRepoInfo GitHubRepoInfo => new GitHubRepoInfo("alexandresanlim/DiscoverGists");

        public Uri ExternalUri => null;

        public bool ContainsAndroidSample => true;

        public bool ContainsiOSSample => true;

        public bool ContainsUWPSample => false;
        
        public Sdk BuiltWith => Sdk.XamarinForms;

        public IAmAnAuthor AuthorInfo => new AlexandreSanlim();

        public IEnumerable<Uri> ImageUris => new List<Uri>
        {
            new Uri("https://github.com/alexandresanlim/DiscoverGists/raw/master/DiscoverGists/DiscoverGists/Src/Screenshots/Android/animation.gif?raw=true"),
            new Uri("https://github.com/alexandresanlim/DiscoverGists/raw/master/DiscoverGists/DiscoverGists/Src/Screenshots/Android/0.png?raw=true"),
            new Uri("https://github.com/alexandresanlim/DiscoverGists/raw/master/DiscoverGists/DiscoverGists/Src/Screenshots/Android/1.png?raw=true"),
            new Uri("https://github.com/alexandresanlim/DiscoverGists/raw/master/DiscoverGists/DiscoverGists/Src/Screenshots/Android/2.png?raw=true"),
            new Uri("https://github.com/alexandresanlim/DiscoverGists/raw/master/DiscoverGists/DiscoverGists/Src/Screenshots/Android/3.png?raw=true"),
            new Uri("https://github.com/alexandresanlim/DiscoverGists/raw/master/DiscoverGists/DiscoverGists/Src/Screenshots/Android/4.png?raw=true"),
            new Uri("https://github.com/alexandresanlim/DiscoverGists/raw/master/DiscoverGists/DiscoverGists/Src/Screenshots/Android/5.png?raw=true"),
            new Uri("https://github.com/alexandresanlim/DiscoverGists/raw/master/DiscoverGists/DiscoverGists/Src/Screenshots/Android/6.png?raw=true"),
            new Uri("https://github.com/alexandresanlim/DiscoverGists/raw/master/DiscoverGists/DiscoverGists/Src/Screenshots/Android/7.png?raw=true"),
            new Uri("https://github.com/alexandresanlim/DiscoverGists/blob/master/DiscoverGists/DiscoverGists/Src/Screenshots/iOS/0.png?raw=true"),
            new Uri("https://github.com/alexandresanlim/DiscoverGists/blob/master/DiscoverGists/DiscoverGists/Src/Screenshots/iOS/1.png?raw=true"),
            new Uri("https://github.com/alexandresanlim/DiscoverGists/blob/master/DiscoverGists/DiscoverGists/Src/Screenshots/iOS/2.png?raw=true"),
        };

        public IList<Category> Categories => new List<Category>
        {
            Category.CARDS, Category.SOCIALNETWORK, Category.LISTS
        };
    }
}
