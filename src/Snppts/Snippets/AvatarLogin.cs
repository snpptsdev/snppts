using System;
using System.Collections.Generic;
using Snppts.Authors;
using Snppts.Extensions;
using Snppts.Infrastructure;

namespace Snppts.Snippets
{
    public class AvatarLogin : IAmASnippet
    {
        public string Slug => "avatar login";
        public string Title => "Avatar Login";
        public GitHubRepoInfo GitHubRepoInfo => new GitHubRepoInfo("aimore/XamQuiz");
        public bool ContainsAndroidSample => true;
        public bool ContainsiOSSample => true;
        public bool ContainsUWPSample => false;

        public string Description => "This snippet was created to demonstrate a basic Login Page with animated avatar and some animation";

        public IAmAnAuthor AuthorInfo => new AimoreSa();

        public IEnumerable<Uri> ImageUris => new List<Uri>
        {
            new Uri("https://i.imgur.com/8hQyajs.jpg"),
            new Uri("https://i.imgur.com/faN2yIY.png")
        };

        public IList<Category> Categories => new List<Category>
        {
            Category.LOGIN
        };

        public Uri ExternalUri => null;
    }
}
