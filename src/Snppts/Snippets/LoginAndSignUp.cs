using System;
using System.Collections.Generic;
using Snppts.Authors;
using Snppts.Infrastructure;

namespace Snppts.Snippets
{
    public class LoginAndSignUp : IAmASnippet
    {
        public string Slug => "Login and Sign Up";
        public string Title => "Login and Sign Up Page";
        public string GithubRepoName => "logeshpalani98/Xamarin_UI";
        public bool ContainsAndroidSample => true;
        public bool ContainsiOSSample => true;
        public bool ContainsUWPSample => false;

        public string Description => "A simple and clean good looking login and sign up screen";

        public IAmAnAuthor AuthorInfo => new LogeshPalani();

        public IEnumerable<Uri> ImageUris => new List<Uri>
        {
            new Uri("https://raw.githubusercontent.com/logeshpalani98/Xamarin_UI/master/XamarinForms_SignupLogin/Screenshot/IMG_0754.jpg"),
            new Uri("https://raw.githubusercontent.com/logeshpalani98/Xamarin_UI/master/XamarinForms_SignupLogin/Screenshot/IMG_0755.jpg")
        };

        public IList<Category> Categories => new List<Category>
        {
            Category.LOGIN, Category.CARDS,Category.SIGNUPS
        };

        public Uri ExternalUri => new Uri("https://github.com/logeshpalani98/Xamarin_UI");
    }
}
