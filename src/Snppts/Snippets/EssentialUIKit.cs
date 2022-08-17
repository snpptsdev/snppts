using System;
using System.Collections.Generic;
using Snppts.Authors;
using Snppts.Extensions;
using Snppts.Infrastructure;

namespace Snppts.Snippets
{
    public class EssentialUIKit : IAmASnippet
    {
        public string Slug => "essential-ui-kit";
        public string Title => "Essential UI Kit";
        public GitHubRepoInfo GitHubRepoInfo => new GitHubRepoInfo("syncfusion/essential-ui-kit-for-xamarin.forms");
        public bool ContainsAndroidSample => true;
        public bool ContainsiOSSample => true;
        public bool ContainsUWPSample => true;
        public Sdk BuiltWith => Sdk.XamarinForms;

        public string Description => "Free and beautiful XAML pages for Xamarin.Forms apps by <a href=\"https://www.syncfusion.com/xamarin-ui-controls\" target=\"_blank\">Syncfusion</a>";

        public IAmAnAuthor AuthorInfo => new Syncfusion();

        public IEnumerable<Uri> ImageUris => new List<Uri>
        {
            //Android
            new Uri("https://cdn.syncfusion.com/essential-ui-kit-for-xamarin.forms/common/uikitimages/screenshots/android/Cart%20Page.jpg"),
            new Uri("https://cdn.syncfusion.com/essential-ui-kit-for-xamarin.forms/common/uikitimages/screenshots/android/Detail%20page.jpg"),
            new Uri("https://cdn.syncfusion.com/essential-ui-kit-for-xamarin.forms/common/uikitimages/screenshots/android/Location%20denied%20page.jpg"),
            new Uri("https://cdn.syncfusion.com/essential-ui-kit-for-xamarin.forms/common/uikitimages/screenshots/android/Login%20page.jpg"),
            new Uri("https://cdn.syncfusion.com/essential-ui-kit-for-xamarin.forms/common/uikitimages/screenshots/android/Onboarding.jpg"),

            //iOS
            new Uri("https://cdn.syncfusion.com/essential-ui-kit-for-xamarin.forms/common/uikitimages/screenshots/ios/Cart%20page.jpg"),
            new Uri("https://cdn.syncfusion.com/essential-ui-kit-for-xamarin.forms/common/uikitimages/screenshots/ios/Detail%20page.jpg"),
            new Uri("https://cdn.syncfusion.com/essential-ui-kit-for-xamarin.forms/common/uikitimages/screenshots/ios/Location%20denied%20page.jpg"),
            new Uri("https://cdn.syncfusion.com/essential-ui-kit-for-xamarin.forms/common/uikitimages/screenshots/ios/Login%20page.jpg"),
            new Uri("https://cdn.syncfusion.com/essential-ui-kit-for-xamarin.forms/common/uikitimages/screenshots/ios/Onboarding.jpg"),

            //UWP
            new Uri("https://cdn.syncfusion.com/essential-ui-kit-for-xamarin.forms/common/uikitimages/screenshots/uwp/Cart%20page.jpg"),
            new Uri("https://cdn.syncfusion.com/essential-ui-kit-for-xamarin.forms/common/uikitimages/screenshots/uwp/Detail.jpg"),
            new Uri("https://cdn.syncfusion.com/essential-ui-kit-for-xamarin.forms/common/uikitimages/screenshots/uwp/Location%20denied%20page.jpg"),
            new Uri("https://cdn.syncfusion.com/essential-ui-kit-for-xamarin.forms/common/uikitimages/screenshots/uwp/Login%20page.jpg"),
            new Uri("https://cdn.syncfusion.com/essential-ui-kit-for-xamarin.forms/common/uikitimages/screenshots/uwp/Onboarding%20page.jpg"),
        };

        public IList<Category> Categories => new List<Category>
        {
            Category.ABOUT, Category.LAUNCHSCREEN, Category.LOGIN, Category.MESSAGING, Category.NAVIGATIONS, Category.PRODUCTS, Category.SIGNUPS, Category.WALKTHROUGHS, Category.ARTICLES, Category.ERRORS, Category.PROFILES
        };

        public Uri ExternalUri => new Uri("https://www.syncfusion.com/xamarin-ui-controls");
    }
}