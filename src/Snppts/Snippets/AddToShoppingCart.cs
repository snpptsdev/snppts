using Snppts.Authors;
using Snppts.Extensions;
using Snppts.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Snppts.Snippets
{
    public class AddToShoppingCart : IAmASnippet
    {
        public string Slug => "addtoshoppingcart";

        public string Title => "Add to Shopping Cart";

        public string Description => "Xamarin UI sample to add item to shopping cart";

        public GitHubRepoInfo GitHubRepoInfo => new GitHubRepoInfo("alexandresanlim/XamarinUI.AddToShoppingCart");

        public Uri ExternalUri => null;

        public bool ContainsAndroidSample => true;

        public bool ContainsiOSSample => true;

        public bool ContainsUWPSample => false;

        public IAmAnAuthor AuthorInfo => new AlexandreSanlim();

        public IEnumerable<Uri> ImageUris => new List<Uri>
        {
            new Uri("https://github.com/alexandresanlim/XamarinUI.AddToShoppingCart/raw/master/XamarinUI.AddToShoppingCard/XamarinUI.AddToShoppingCard/Src/img/screen/gif.gif?raw=true"),
            new Uri("https://github.com/alexandresanlim/XamarinUI.AddToShoppingCart/raw/master/XamarinUI.AddToShoppingCard/XamarinUI.AddToShoppingCard/Src/img/screen/ios/not1.png?raw=true"),
            new Uri("https://github.com/alexandresanlim/XamarinUI.AddToShoppingCart/raw/master/XamarinUI.AddToShoppingCard/XamarinUI.AddToShoppingCard/Src/img/screen/ios/not2.png?raw=true"),
            new Uri("https://github.com/alexandresanlim/XamarinUI.AddToShoppingCart/raw/master/XamarinUI.AddToShoppingCard/XamarinUI.AddToShoppingCard/Src/img/screen/ios/not3.png?raw=true"),
            new Uri("https://github.com/alexandresanlim/XamarinUI.AddToShoppingCart/raw/master/XamarinUI.AddToShoppingCard/XamarinUI.AddToShoppingCard/Src/img/screen/ios/not4.png?raw=true"),
            new Uri("https://github.com/alexandresanlim/XamarinUI.AddToShoppingCart/raw/master/XamarinUI.AddToShoppingCard/XamarinUI.AddToShoppingCard/Src/img/screen/ios/not5.png?raw=true")
        };

        public IList<Category> Categories => new List<Category>
        {
            Category.STORES,
            Category.SHOPPINGCART
        };
    }
}
