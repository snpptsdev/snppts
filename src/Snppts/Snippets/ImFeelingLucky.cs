using Snppts.Authors;
using Snppts.Extensions;
using Snppts.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Snppts.Snippets
{
    public class ImFeelingLucky : IAmASnippet
    {
        public string Slug => "im-feeling-lucky";

        public string Title => "I'm Feeling Lucky";

        public string Description => "It's a feeling lucky page with animations";

        public GitHubRepoInfo GitHubRepoInfo => new GitHubRepoInfo("alexandresanlim/XamarinUI.ImFeelingLucky");

        public Uri ExternalUri => null;

        public bool ContainsAndroidSample => true;

        public bool ContainsiOSSample => true;

        public bool ContainsUWPSample => false;

        public IAmAnAuthor AuthorInfo => new AlexandreSanlim();

        public IEnumerable<Uri> ImageUris => new List<Uri>
        {
            new Uri("https://github.com/alexandresanlim/XamarinUI.ImFeelingLucky/raw/master/XamarinUI.ImFeelingLucky/XamarinUI.ImFeelingLucky/Src/Screen/gif.gif?raw=true"),
            new Uri("https://github.com/alexandresanlim/XamarinUI.ImFeelingLucky/raw/master/XamarinUI.ImFeelingLucky/XamarinUI.ImFeelingLucky/Src/Screen/android/1.jpg?raw=true"),
            new Uri("https://github.com/alexandresanlim/XamarinUI.ImFeelingLucky/raw/master/XamarinUI.ImFeelingLucky/XamarinUI.ImFeelingLucky/Src/Screen/android/2.jpg?raw=true"),
            new Uri("https://github.com/alexandresanlim/XamarinUI.ImFeelingLucky/raw/master/XamarinUI.ImFeelingLucky/XamarinUI.ImFeelingLucky/Src/Screen/android/3.jpg?raw=true"),
            new Uri("https://github.com/alexandresanlim/XamarinUI.ImFeelingLucky/raw/master/XamarinUI.ImFeelingLucky/XamarinUI.ImFeelingLucky/Src/Screen/ios/1.png?raw=true"),
            new Uri("https://github.com/alexandresanlim/XamarinUI.ImFeelingLucky/raw/master/XamarinUI.ImFeelingLucky/XamarinUI.ImFeelingLucky/Src/Screen/ios/2.png?raw=true"),
            new Uri("https://github.com/alexandresanlim/XamarinUI.ImFeelingLucky/raw/master/XamarinUI.ImFeelingLucky/XamarinUI.ImFeelingLucky/Src/Screen/ios/3.png?raw=true")
        };

        public IList<Category> Categories => new List<Category>
        {
            Category.CARDS
        };
    }
}
