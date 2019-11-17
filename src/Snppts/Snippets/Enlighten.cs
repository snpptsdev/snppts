using Snppts.Authors;
using Snppts.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Snppts.Snippets
{
    
    public class Enlighten : IAmASnippet
    {
        public string Slug => "Enlighten";
        public string Title => "Enlighten";
        public string GithubRepoName => "devoirtechsandip/SnpptsChallenge";
        public bool ContainsAndroidSample => true;
        public bool ContainsiOSSample => true;
        public bool ContainsUWPSample => false;

        public string Description => "A Xamarin.Forms application for Students.";

        public IAmAnAuthor AuthorInfo => new SandipKumbhar();

        public IEnumerable<Uri> ImageUris => new List<Uri>
        {
            new Uri("https://github.com/devoirtechsandip/SnpptsChallenge/blob/master/Screenshot_20191117-182623.jpg"),
            new Uri("https://github.com/devoirtechsandip/SnpptsChallenge/blob/master/Screenshot_20191117-182628.jpg"),
             new Uri("https://github.com/devoirtechsandip/SnpptsChallenge/blob/master/Screenshot_20191117-182636.jpg"),
              new Uri("https://github.com/devoirtechsandip/SnpptsChallenge/blob/master/Screenshot_20191117-182650.jpg"),
               new Uri("https://github.com/devoirtechsandip/SnpptsChallenge/blob/master/Screenshot_20191117-183621.jpg"),
                new Uri("https://github.com/devoirtechsandip/SnpptsChallenge/blob/master/Screenshot_20191117-183633.jpg"),
                 new Uri("https://github.com/devoirtechsandip/SnpptsChallenge/blob/master/Screenshot_20191117-183641.jpg"),
             new Uri("https://github.com/devoirtechsandip/SnpptsChallenge/blob/master/Screenshot_20191117-183647.jpg")
        };

        public IList<Category> Categories => new List<Category>
        {
            Category.LOGIN, Category.LISTS
        };

        public Uri ExternalUri => new Uri("https://play.google.com/store/apps/details?id=com.devoirtech.enlighten");
    }
}
