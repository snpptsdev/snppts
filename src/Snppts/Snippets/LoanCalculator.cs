using System;
using System.Collections.Generic;
using Snppts.Authors;
using Snppts.Extensions;
using Snppts.Infrastructure;

namespace Snppts.Snippets
{
    public class LoanCalculator : IAmASnippet
    {
        public string Slug => "loan-calculator";
        public string Title => "Loan Calculator";
        public GitHubRepoInfo GitHubRepoInfo => new GitHubRepoInfo("syncfusion/xamarin-showcase-emi-calculator");
        public bool ContainsAndroidSample => true;
        public bool ContainsiOSSample => true;
        public bool ContainsUWPSample => false;

        public string Description => "The Loan Calculator is an application developed using Xamarin.Forms and <a href=\"https://www.syncfusion.com/xamarin-ui-controls\" target=\"_blank\">Syncfusion</a> controls to calculate the EMI with the given details of principal amount, tenure, and interest";

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
            Category.CHARTS, Category.DATAGRID, Category.CALCULATORS
        };

        public Uri ExternalUri => new Uri("https://www.syncfusion.com/xamarin-ui-controls");
    }
}