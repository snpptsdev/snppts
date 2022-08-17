using System;
using System.Collections.Generic;
using Snppts.Authors;
using Snppts.Extensions;
using Snppts.Infrastructure;

namespace Snppts.Snippets
{
    public class NuBankSimilarTimeline : IAmASnippet
    {
        public string Slug => "nubank-similar-timeline";
        public string Title => "NuBank Similar Timeline";
        public GitHubRepoInfo GitHubRepoInfo => new GitHubRepoInfo("ionixjunior/xamarin-forms-interfaces");
        public bool ContainsAndroidSample => true;
        public bool ContainsiOSSample => true;
        public bool ContainsUWPSample => false;
        public Sdk BuiltWith => Sdk.XamarinForms;

        public string Description => "Inspired in NuBank app, a simple timeline implementation using ListView with ViewCells and header.\n\nSome details about implementation:\n\nListView header was made using CarouselView.FormsPlugin to show some informations.\nFor a better aspect, the fonts was changed to Gotham-Bold and Gotham-Light.\nTo show correct date time information, was created a converter to parse DateTime object and transform in string.";

        public IAmAnAuthor AuthorInfo => new IoneSouzaJunior();

        public IEnumerable<Uri> ImageUris => new List<Uri>
        {
            new Uri("https://raw.githubusercontent.com/snpptsdev/MigratedImages/master/138/166.jpg"),
            new Uri("https://raw.githubusercontent.com/snpptsdev/MigratedImages/master/138/167.jpg")
        };

        public IList<Category> Categories => new List<Category>
        {
            Category.TIMELINE
        };

        public Uri ExternalUri => null;
    }
}
