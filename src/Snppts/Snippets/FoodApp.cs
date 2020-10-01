using System;
using System.Collections.Generic;
using Snppts.Authors;
using Snppts.Extensions;
using Snppts.Infrastructure;

namespace Snppts.Snippets
{
    public class FoodApp : IAmASnippet
    {
        public string Slug => "foodapp";
        public string Title => "foodapp";
        public GitHubRepoInfo GitHubRepoInfo => new GitHubRepoInfo("danielmonettelli/XF_FoodApp");
        public bool ContainsAndroidSample => true;
        public bool ContainsiOSSample => true;
        public bool ContainsUWPSample => true;

        public string Description => "FoodApp is an application focused on good practices that should be in the Styles of Xamarin.Forms.";

        public IAmAnAuthor AuthorInfo => new DanielMonettelli();

        public IEnumerable<Uri> ImageUris => new List<Uri>
        {
            new Uri("https://raw.githubusercontent.com/monetelli/XF_FoodApp/master/Images/SplashScreen-iOS.png"),
            new Uri("https://raw.githubusercontent.com/monetelli/XF_FoodApp/master/Images/Discover-White-iOS.png"),
            new Uri("https://raw.githubusercontent.com/monetelli/XF_FoodApp/master/Images/MyOrders-White-iOS.png"),
            new Uri("https://raw.githubusercontent.com/monetelli/XF_FoodApp/master/Images/Favourite-White-iOS.png"),
            new Uri("https://raw.githubusercontent.com/monetelli/XF_FoodApp/master/Images/MyProfile-White-iOS.png"),

            new Uri("https://raw.githubusercontent.com/monetelli/XF_FoodApp/master/Images/Discover-Dark-iOS.png"),
            new Uri("https://raw.githubusercontent.com/monetelli/XF_FoodApp/master/Images/MyOrders-Dark-iOS.png"),
            new Uri("https://raw.githubusercontent.com/monetelli/XF_FoodApp/master/Images/Favourite-Dark-iOS.png"),
            new Uri("https://raw.githubusercontent.com/monetelli/XF_FoodApp/master/Images/MyProfile-Dark-iOS.png"),



            new Uri("https://raw.githubusercontent.com/monetelli/XF_FoodApp/master/Images/SplashScreen-Android.png"),
            new Uri("https://raw.githubusercontent.com/monetelli/XF_FoodApp/master/Images/Discover-White-Android.png"),
            new Uri("https://raw.githubusercontent.com/monetelli/XF_FoodApp/master/Images/MyOrders-White-Android.png"),
            new Uri("https://raw.githubusercontent.com/monetelli/XF_FoodApp/master/Images/Favourite-White-Android.png"),
            new Uri("https://raw.githubusercontent.com/monetelli/XF_FoodApp/master/Images/MyProfile-White-Android.png"),

            new Uri("https://raw.githubusercontent.com/monetelli/XF_FoodApp/master/Images/Discover-Dark-Android.png"),
            new Uri("https://raw.githubusercontent.com/monetelli/XF_FoodApp/master/Images/MyOrders-Dark-Android.png"),
            new Uri("https://raw.githubusercontent.com/monetelli/XF_FoodApp/master/Images/Favourite-Dark-Android.png"),
            new Uri("https://raw.githubusercontent.com/monetelli/XF_FoodApp/master/Images/MyProfile-Dark-Android.png"),
        };

        public IList<Category> Categories => new List<Category>
        {
            Category.PRODUCTS, Category.CARDS, Category.PHOTOS, Category.PROFILES
        };

        public Uri ExternalUri => new Uri("https://danielmonetelli.azurewebsites.net/creating-a-clean-style-library-for-xamarin-forms-v1-0/");
    }
}
