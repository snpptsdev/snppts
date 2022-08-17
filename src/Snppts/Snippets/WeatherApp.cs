using Snppts.Authors;
using Snppts.Extensions;
using Snppts.Infrastructure;
using System;
using System.Collections.Generic;

namespace Snppts.Snippets
{
    public class WeatherApp : IAmASnippet
    {
        public string Slug => "weather-app-ui";
        public string Title => "Weather App UI";
        public string GithubRepoName => "valentineg8/WeatherApp";
        public GitHubRepoInfo GitHubRepoInfo => new GitHubRepoInfo("valentineg8/WeatherApp");
        public bool ContainsAndroidSample => true;
        public bool ContainsiOSSample => true;
        public bool ContainsUWPSample => false;
        public Sdk BuiltWith => Sdk.XamarinForms;

        public string Description => "A Xamarin.Forms Weather App Ui.";

        public IAmAnAuthor AuthorInfo => new LorenzoAraujo();

        public IEnumerable<Uri> ImageUris => new List<Uri>
        {
            new Uri("https://raw.githubusercontent.com/valentineg8/WeatherApp/master/images/ios.gif?raw=true"),
            new Uri("https://raw.githubusercontent.com/valentineg8/WeatherApp/master/images/android.gif?raw=true")
        };

        public IList<Category> Categories => new List<Category>
        {
            Category.DASHBOARD
        };

        public Uri ExternalUri => null;

    }
}
