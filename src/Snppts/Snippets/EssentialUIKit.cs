using System;
using System.Collections.Generic;
using Snppts.Authors;
using Snppts.Infrastructure;

namespace Snppts.Snippets
{
    public class EssentialUIKit : IAmASnippet
    {
        public string Slug => "essential-ui-kit";
        public string Title => "Essential UI Kit";
        public string GithubRepoName => "syncfusion/essential-ui-kit-for-xamarin.forms";
        public bool ContainsAndroidSample => true;
        public bool ContainsiOSSample => true;
        public bool ContainsUWPSample => true;

        public string Description => "Free and beautiful XAML pages for Xamarin.Forms apps by <a href=\"https://www.syncfusion.com/xamarin-ui-controls\" target=\"_blank\">Syncfusion</a>";

        public IAmAnAuthor AuthorInfo => new Syncfusion();

        public IEnumerable<Uri> ImageUris => new List<Uri>
        {
            new Uri("https://raw.githubusercontent.com/syncfusion/xamarin-showcase-emi-calculator/master/images/Android/home.png"),
            new Uri("https://raw.githubusercontent.com/syncfusion/xamarin-showcase-emi-calculator/master/images/Android/chart.png"),
            new Uri("https://raw.githubusercontent.com/syncfusion/xamarin-showcase-emi-calculator/master/images/Android/grid.png"),
            new Uri("https://raw.githubusercontent.com/syncfusion/xamarin-showcase-emi-calculator/master/images/Android/share.png"),
            new Uri("https://raw.githubusercontent.com/syncfusion/xamarin-showcase-emi-calculator/master/images/Android/excel.png"),
            new Uri("https://raw.githubusercontent.com/syncfusion/xamarin-showcase-emi-calculator/master/images/iOS/home.png"),
            new Uri("https://raw.githubusercontent.com/syncfusion/xamarin-showcase-emi-calculator/master/images/iOS/chart.png"),
            new Uri("https://raw.githubusercontent.com/syncfusion/xamarin-showcase-emi-calculator/master/images/iOS/grid.png"),
            new Uri("https://raw.githubusercontent.com/syncfusion/xamarin-showcase-emi-calculator/master/images/iOS/share.png"),
            new Uri("https://raw.githubusercontent.com/syncfusion/xamarin-showcase-emi-calculator/master/images/iOS/excel.png")
        };

        public IList<Category> Categories => new List<Category>
        {
            Category.ABOUT, Category.LAUNCHSCREEN, Category.LOGIN, Category.MESSAGING, Category.NAVIGATIONS, Category.PRODUCTS, Category.SIGNUPS, Category.WALKTHROUGHS, Category.ARTICLES, Category.ERRORS, Category.PROFILES
        };

        public Uri ExternalUri => null;
    }
}