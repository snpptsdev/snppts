using Snppts.Authors;
using Snppts.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Snppts.Snippets
{
    public class CruiseMobileUI : IAmASnippet
    {
        public string Slug => "cruise-mobile-ui";

        public string Title => "Cruise Mobile UI";

        public string Description => "A Xamarin.Forms UI Challenge based on a Behance design.";

        public string GithubRepoName => "andreas-nesheim/CruiseMobileUI";

        public Uri ExternalUri => new Uri("https://www.andreasnesheim.no/xamarin-ui-challenge-cruise-mobile-ui-part-1/");

        public bool ContainsAndroidSample => true;

        public bool ContainsiOSSample => true;

        public bool ContainsUWPSample => false;

        public IAmAnAuthor AuthorInfo => new AndreasNesheim();

        public IEnumerable<Uri> ImageUris => new List<Uri>
        {
            new Uri("https://github.com/andreas-nesheim/CruiseMobileUI/raw/master/Screenshots/screenshot1.png"),
            new Uri("https://github.com/andreas-nesheim/CruiseMobileUI/raw/master/Screenshots/screenshot2.png")
        };

        public IList<Category> Categories => new List<Category>
        {
            Category.LISTS,
            Category.PRODUCTS
        };
    }
}
