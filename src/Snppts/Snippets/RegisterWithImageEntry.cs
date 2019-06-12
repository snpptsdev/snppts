using System;
using System.Collections.Generic;
using Snppts.Authors;
using Snppts.Infrastructure;

namespace Snppts.Snippets
{
    public class RegisterWithImageEntry : IAmASnippet
    {
        public string Slug => "register-with-imageentry";
        public string Title => "Register with ImageEntry";
        public string GithubRepoName => "CrossGeeks/Xamarin.Forms.UI";
        public bool ContainsAndroidSample => true;
        public bool ContainsiOSSample => true;
        public bool ContainsUWPSample => false;

        public string Description => "SignUp UI. NOTE: Check I'm using a custom renderer, the implementation is in the Android/iOS project. <a href=\"https://xamgirl.com/image-entry-in-xamarin-forms\" target=\"_blank\">https://xamgirl.com/image-entry-in-xamarin-forms</a>.";

        public IAmAnAuthor AuthorInfo => new CharlinAgramonte();

        public IEnumerable<Uri> ImageUris => new List<Uri>
        {
            new Uri("https://raw.githubusercontent.com/snpptsdev/MigratedImages/master/69/116.jpg")
        };

        public IList<Category> Categories => new List<Category>
        {
            Category.SIGNUPS
        };
    }
}
