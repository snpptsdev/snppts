using Snppts.Authors;
using Snppts.Extensions;
using Snppts.Infrastructure;
using System;
using System.Collections.Generic;

namespace Snppts.Snippets
{
    public class XFEcommerceHeadPhones : IAmASnippet
    {
        public string Slug => "xamarinforms-ecommerce-headphones";
        public string Title => "XamarinForms Headphones e-commerce concept";
        public string Description => "Headset e-commerce concept developed at XamarinForms";
        public GitHubRepoInfo GitHubRepoInfo => new GitHubRepoInfo("Altevir/xamarinforms-ecommerce-headphones");
        public Uri ExternalUri => null;
        public bool ContainsAndroidSample => true;
        public bool ContainsiOSSample => true;
        public bool ContainsUWPSample => false;
        public IAmAnAuthor AuthorInfo => new AltevirCardosoNeto();

        public IEnumerable<Uri> ImageUris => new List<Uri>
        {
            new Uri("https://user-images.githubusercontent.com/11803107/83947598-5cd8f980-a7ee-11ea-86a6-ea9567a6906b.jpg"),
            new Uri("https://user-images.githubusercontent.com/11803107/83947601-64000780-a7ee-11ea-82cc-dfbe14322e21.jpg"),
            new Uri("https://user-images.githubusercontent.com/11803107/83947639-9f9ad180-a7ee-11ea-840c-919acbfe681b.PNG"),
            new Uri("https://user-images.githubusercontent.com/11803107/83947643-a6c1df80-a7ee-11ea-9922-824b9aab951e.PNG"),
            new Uri("https://user-images.githubusercontent.com/11803107/83947779-89d9dc00-a7ef-11ea-8ac8-e212a32c106d.gif")
        };

        public IList<Category> Categories => new List<Category>
        {
            Category.LISTS,
            Category.PHOTOS,
            Category.SEARCH,
            Category.CARDS,
            Category.PRODUCTS
        };
    }
}
