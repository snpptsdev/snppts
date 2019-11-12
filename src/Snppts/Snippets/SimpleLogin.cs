using System;
using System.Collections.Generic;
using Snppts.Infrastructure;

namespace Snppts.Snippets
{
    public class SimpleLogin : IAmASnippet
    {
        public string Slug => "simple-login";
        public string Title => "Simple Login";
        public string Description => "A simple login with option to continue as guest.";
        public string GithubRepoName => "leijae/SimpleLogin";
        public Uri ExternalUri { get; }
        public bool ContainsAndroidSample => true;
        public bool ContainsiOSSample => true;
        public bool ContainsUWPSample => false;
        public IAmAnAuthor AuthorInfo => new EricLeija();
        public IEnumerable<Uri> ImageUris => new List<Uri> { new Uri("https://raw.githubusercontent.com/leijae/SimpleLogin/master/SimpleLogin/SimpleLogin/SimpleLogin/Screenshot/login.png") };
        public IList<Category> Categories => new List<Category> { Category.LOGIN };
    }
}
