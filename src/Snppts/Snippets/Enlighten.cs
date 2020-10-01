using Snppts.Authors;
using Snppts.Extensions;
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
        public GitHubRepoInfo GitHubRepoInfo => new GitHubRepoInfo("devoirtechsandip/SnpptsChallenge");
        public bool ContainsAndroidSample => true;
        public bool ContainsiOSSample => true;
        public bool ContainsUWPSample => false;

        public string Description => "A Xamarin.Forms application for Students.";

        public IAmAnAuthor AuthorInfo => new SandipKumbhar();

        public IEnumerable<Uri> ImageUris => new List<Uri>
        {
            new Uri("https://user-images.githubusercontent.com/26998235/69323704-3f3aad00-0c6d-11ea-8195-6b5f1c64d665.jpg"),
            new Uri("https://user-images.githubusercontent.com/26998235/69323706-3f3aad00-0c6d-11ea-92f7-939a99ea58c9.jpg"),
             new Uri("https://user-images.githubusercontent.com/26998235/69323707-3f3aad00-0c6d-11ea-96f9-b04ccd6edd3d.jpg"),
              new Uri("https://user-images.githubusercontent.com/26998235/69323708-3fd34380-0c6d-11ea-9825-13964fe58206.jpg"),
               new Uri("https://user-images.githubusercontent.com/26998235/69323710-3fd34380-0c6d-11ea-9204-cc560d3050d3.jpg"),
                new Uri("https://user-images.githubusercontent.com/26998235/69323712-3fd34380-0c6d-11ea-8d48-2dd9cf5ff990.jpg"),
                 new Uri("https://user-images.githubusercontent.com/26998235/69323714-406bda00-0c6d-11ea-9eac-f08220f21566.jpg"),
             new Uri("https://user-images.githubusercontent.com/26998235/69323716-406bda00-0c6d-11ea-993b-4d0ab21b46bf.jpg")
        };

        public IList<Category> Categories => new List<Category>
        {
            Category.LOGIN, Category.LISTS, Category.MESSAGING, Category.SIGNUPS, Category.ARTICLES
        };

        public Uri ExternalUri => new Uri("https://play.google.com/store/apps/details?id=com.devoirtech.enlighten");
    }
}
