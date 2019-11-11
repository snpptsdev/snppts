using System;
using System.Collections.Generic;
using Snppts.Infrastructure;

namespace Snppts.Snippets
{
    public class SimpleLogin : IAmASnippet
    {
        public string Slug => "simple-login";
        public string Title => "Simple Login";
        public string Description { get; }
        public string GithubRepoName { get; }
        public Uri ExternalUri { get; }
        public bool ContainsAndroidSample => true;
        public bool ContainsiOSSample => true;
        public bool ContainsUWPSample => false;
        public IAmAnAuthor AuthorInfo => new EricLeija();
        public IEnumerable<Uri> ImageUris { get; }
        public IList<Category> Categories { get; }
    }
}
