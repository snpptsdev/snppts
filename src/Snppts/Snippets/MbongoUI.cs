using Snppts.Authors;
using Snppts.Extensions;
using Snppts.Infrastructure;
using System;
using System.Collections.Generic;

namespace Snppts.Snippets
{
    public class MbongoUI : IAmASnippet
    {
        public string Slug => "MbongoUI";
        public string Title => "MbongoUI";
        public string Description => "Developed in XamarinForms to show how we can develop beatifful screens with XamarinForms";
        public GitHubRepoInfo GitHubRepoInfo => new GitHubRepoInfo("Amaro96/MbongoUIApp");
        public Uri ExternalUri => null;
        public bool ContainsAndroidSample => true;
        public bool ContainsiOSSample => false;
        public bool ContainsUWPSample => false;
        public IAmAnAuthor AuthorInfo => new AmaroManungu();

        public IEnumerable<Uri> ImageUris => new List<Uri>
        {
            new Uri("https://raw.githubusercontent.com/Amaro96/MbongoUIApp/master/ScreenShots/Mobile%20money.PNG"),
            new Uri("https://raw.githubusercontent.com/Amaro96/MbongoUIApp/master/ScreenShots/bankTransfer.PNG"),
        };

        public IList<Category> Categories => new List<Category>
        {                    			
            Category.WIDGETS,
			Category.LAUNCHSCREEN,
            Category.LISTS
        };
    }
}
