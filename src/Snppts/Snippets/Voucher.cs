using Snppts.Authors;
using Snppts.Extensions;
using Snppts.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Snppts.Snippets
{
    public class Voucher : IAmASnippet
    {
        public string Slug => "voucher";

        public string Title => "Voucher";

        public string Description => "It's a voucher list sample";

        public GitHubRepoInfo GitHubRepoInfo => new GitHubRepoInfo("AlexandreSanlim/XamarinUI.Voucher");

        public Uri ExternalUri => null;

        public bool ContainsAndroidSample => true;

        public bool ContainsiOSSample => true;

        public bool ContainsUWPSample => false;

        public Sdk BuiltWith => Sdk.XamarinForms;

        public IAmAnAuthor AuthorInfo => new AlexandreSanlim();

        public IEnumerable<Uri> ImageUris => new List<Uri>
        {
            new Uri("https://github.com/alexandresanlim/XamarinUI.Voucher/raw/master/XamarinUI.Voucher/XamarinUI.Voucher/src/screen/demo.gif?raw=true"),
            new Uri("https://github.com/alexandresanlim/XamarinUI.Voucher/raw/master/XamarinUI.Voucher/XamarinUI.Voucher/src/screen/android/1.jpg?raw=true"),
            new Uri("https://github.com/alexandresanlim/XamarinUI.Voucher/raw/master/XamarinUI.Voucher/XamarinUI.Voucher/src/screen/ios/1.png?raw=true"),
            new Uri("https://github.com/alexandresanlim/XamarinUI.Voucher/raw/master/XamarinUI.Voucher/XamarinUI.Voucher/src/screen/ios/2.png?raw=true")
        };

        public IList<Category> Categories => new List<Category>
        {
             Category.STORES,
             Category.CARDS
        };
    }
}
