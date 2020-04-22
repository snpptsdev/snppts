using System;
using System.Collections.Generic;
using Snppts.Authors;
using Snppts.Extensions;
using Snppts.Infrastructure;

namespace Snppts.Snippets
{
    public class Covid19TrackerUI : IAmASnippet
    {
        public string Slug => "covid19-tracker-ui";

        public string Title => "Covid19 Tracker App";

        public string Description => "Covid19.Forms is a tracker app to keep updated with Covid19";

        public GitHubRepoInfo GitHubRepoInfo => new GitHubRepoInfo("AnthonyLatty/Covid19.Forms");

        public Uri ExternalUri => null;

        public bool ContainsAndroidSample => true;

        public bool ContainsiOSSample => true;

        public bool ContainsUWPSample => false;

        public IAmAnAuthor AuthorInfo => new MarcAnthonyLatty();

        public IEnumerable<Uri> ImageUris => new List<Uri>
        {
            new Uri("https://raw.githubusercontent.com/AnthonyLatty/Covid19.Forms/master/Artwork/artwork_droid_3.jpg"),
            new Uri("https://raw.githubusercontent.com/AnthonyLatty/Covid19.Forms/master/Artwork/artwork_droid_1.jpg"),
            new Uri("https://raw.githubusercontent.com/AnthonyLatty/Covid19.Forms/master/Artwork/artwork_droid_2.jpg"),
            new Uri("https://raw.githubusercontent.com/AnthonyLatty/Covid19.Forms/master/Artwork/artwork_ios_3.png"),
            new Uri("https://raw.githubusercontent.com/AnthonyLatty/Covid19.Forms/master/Artwork/artwork_ios_1.png"),
            new Uri("https://raw.githubusercontent.com/AnthonyLatty/Covid19.Forms/master/Artwork/artwork_ios_2.png")
        };

        public IList<Category> Categories => new List<Category>
        {
            Category.CARDS,
            Category.FRIENDS
        };
    }
}
