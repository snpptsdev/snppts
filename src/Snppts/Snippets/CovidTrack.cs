using Snppts.Authors;
using Snppts.Extensions;
using Snppts.Infrastructure;
using System;
using System.Collections.Generic;

namespace Snppts.Snippets
{
    public class CovidTrack : IAmASnippet
    {
        public string Slug => "CovidTrack";
        public string Title => "Covid Tracker";
        public string Description => "Developed with the intuition to show the flow of Covid-19 in the world with real data from each country";
        public GitHubRepoInfo GitHubRepoInfo => new GitHubRepoInfo("Amaro96/CovidTrack");
        public Uri ExternalUri => null;
        public bool ContainsAndroidSample => true;
        public bool ContainsiOSSample => false;
        public bool ContainsUWPSample => false;
        public IAmAnAuthor AuthorInfo => new AmaroManungu();

        public IEnumerable<Uri> ImageUris => new List<Uri>
        {
            new Uri("https://raw.githubusercontent.com/Amaro96/CovidTrack/master/Screenshots/ligthModeFirstScreen.PNG"),
            new Uri("https://raw.githubusercontent.com/Amaro96/CovidTrack/master/Screenshots/light.PNG"),
			new Uri("https://raw.githubusercontent.com/Amaro96/CovidTrack/master/Screenshots/darkModeFirstScreen.png"),
            new Uri("https://raw.githubusercontent.com/Amaro96/CovidTrack/master/Screenshots/tela.PNG"),
			 new Uri("https://raw.githubusercontent.com/Amaro96/CovidTrack/master/Screenshots/mycountry.PNG"),
        };

        public IList<Category> Categories => new List<Category>
        {                    			
            Category.WIDGETS,
			Category.LAUNCHSCREEN,
            Category.LISTS,
			Categories.FILTER,
			Categories.SEARCH
        };
    }
}
