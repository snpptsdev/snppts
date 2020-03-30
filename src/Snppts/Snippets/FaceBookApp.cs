using System;
using System.Collections.Generic;
using Snppts.Authors;
using Snppts.Infrastructure;

namespace Snppts.Snippets
{
    public class FaceBookApp : IAmASnippet
    {
        public string Slug => "FacebookApp";
        public string Title => "Facebook App";
        public string GithubRepoName => "leomarisreyes/FaceBookUISample";
        public bool ContainsAndroidSample => true;
        public bool ContainsiOSSample => true;
        public bool ContainsUWPSample => false;

        public string Description => "It's the replica of Facebook App.";

        public IAmAnAuthor AuthorInfo => new LeomarisReyes();

        public IEnumerable<Uri> ImageUris => new List<Uri>
        {
            new Uri("https://askxammy.com/wp-content/uploads/2019/08/FB_post.png"),
            new Uri("https://askxammy.com/wp-content/uploads/2019/10/AndroidFB.png")
        };

        public IList<Category> Categories => new List<Category>
        {
            Category.APPCLONE
        };

        public Uri ExternalUri => new Uri("https://askxammy.com/replicating-facebook-profile-ui-in-xamarin-forms/");
    }
}
