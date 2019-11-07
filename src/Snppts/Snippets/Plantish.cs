using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Snppts.Authors;
using Snppts.Infrastructure;

namespace Snppts.Snippets
{
    public class Plantish : IAmASnippet
    {
        public string Slug => "plantish";
        public string Title => "Plantish - Manage your plants";

        public string Description =>
            "This app was created to easily manage my plants in my house. The idea is to add your plants, provide a watering frequency and when you last gave your plant water. When the water needs water, the app will notify you and you will have to tell the app that you have watered it.";

        public string GithubRepoName => "haavamoa/Plantish";
        public Uri ExternalUri => null;
        public bool ContainsAndroidSample => true;
        public bool ContainsiOSSample => false;
        public bool ContainsUWPSample => false;
        public IAmAnAuthor AuthorInfo => new HavardMoas();
        public IEnumerable<Uri> ImageUris => new List<Uri>()
        {
            new Uri("https://raw.githubusercontent.com/haavamoa/Plantish/master/assets/SplashScreen.png"),
            new Uri("https://raw.githubusercontent.com/haavamoa/Plantish/master/assets/Plants.png"),
            new Uri("https://raw.githubusercontent.com/haavamoa/Plantish/master/assets/AddPlant.png"),
            new Uri("https://raw.githubusercontent.com/haavamoa/Plantish/master/assets/AddPlant_WithPicture.png"),
        };

        public IList<Category> Categories => new List<Category>() { Category.LAUNCHSCREEN, Category.LISTS, Category.PHOTOS, Category.NOTIFICATIONS, Category.DASHBOARD };
    }
}
