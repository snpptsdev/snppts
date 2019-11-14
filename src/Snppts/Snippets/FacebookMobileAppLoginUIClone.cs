using Snppts.Authors;
using Snppts.Infrastructure;
using System;
using System.Collections.Generic;

namespace Snppts.Snippets
{
    public class FacebookMobileAppLoginUIClone : IAmASnippet
    {
        public string Slug => "facebook-mobile-app-login-ui-clone";
        public string Title => "Facebook Mobile App Login UI Clone";
        public string GithubRepoName => "SRKYousafzaiPK/FacebookMobileAppLoginUIClone";
        public bool ContainsAndroidSample => true;
        public bool ContainsiOSSample => false;
        public bool ContainsUWPSample => false;

        public string Description => "Facebook Mobile App Login UI Clone in Xamarin Forms.";

        public IAmAnAuthor AuthorInfo => new ShahrukhYousafzai();

        public IEnumerable<Uri> ImageUris => new List<Uri>
        {
            new Uri("https://raw.githubusercontent.com/SRKYousafzaiPK/FacebookMobileAppLoginUIClone/master/Screenshot.PNG")
        };

        public IList<Category> Categories => new List<Category>
        {
            Category.LOGIN
        };
    }
}
