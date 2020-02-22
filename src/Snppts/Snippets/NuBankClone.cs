using System;
using System.Collections.Generic;
using Snppts.Authors;
using Snppts.Infrastructure;

namespace Snppts.Snippets
{
    public class NuBankClone : IAmASnippet
    {
        public string Slug => "nubank-clone";
        public string Title => "NuBank Clone";
        public string GithubRepoName => "felipebaltazar/Xam-Nubank";
        public bool ContainsAndroidSample => true;
        public bool ContainsiOSSample => true;
        public bool ContainsUWPSample => false;

        public string Description => "NuBank app clone made with Xamarin.Forms 4.3 and CarouselView";

        public IAmAnAuthor AuthorInfo => new FelipeBaltazar();

        public IEnumerable<Uri> ImageUris => new List<Uri>
        {
            new Uri("https://user-images.githubusercontent.com/19656249/59728878-68bd5b80-922b-11e9-949a-a28b086868ec.png"),
            new Uri("https://user-images.githubusercontent.com/19656249/67351780-b2dd8300-f524-11e9-9b9d-39909880d6fe.gif"),
            new Uri("https://user-images.githubusercontent.com/19656249/59871956-213fe800-936f-11e9-819e-de366123feb1.gif"),
        };

        public IList<Category> Categories => new List<Category>
        {
            Category.DASHBOARD,
            Category.CARDS,
            Category.WIDGETS,
            Category.APPCLONE
        };

        public Uri ExternalUri => null;
    }
}
