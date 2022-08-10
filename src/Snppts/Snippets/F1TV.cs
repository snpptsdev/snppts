using Snppts.Authors;
using Snppts.Extensions;
using Snppts.Infrastructure;
using System;
using System.Collections.Generic;

namespace Snppts.Snippets
{
    public class F1TV : IAmASnippet
    {
        public string Slug => "f1tv";

        public string Title => "F1TV";

        public string Description => "My contribution for the MAUI UI July challenge by replicating the F1TV app.";

        public GitHubRepoInfo GitHubRepoInfo => new GitHubRepoInfo("andreas-nesheim/MAUIUIJuly");

        public Uri ExternalUri => new Uri("https://www.andreasnesheim.no/maui-ui-july-replicating-f1tv-app/");

        public bool ContainsAndroidSample => true;

        public bool ContainsiOSSample => true;

        public bool ContainsUWPSample => false;

        public IAmAnAuthor AuthorInfo => new AndreasNesheim();

        public IEnumerable<Uri> ImageUris => new List<Uri>
        {
            new Uri("https://user-images.githubusercontent.com/11583629/177056864-a8edd821-0cc5-469b-91f9-66e0051f6f35.png")
        };

        public IList<Category> Categories => new List<Category>
        {
            Category.APPCLONE,
            Category.CAROUSEL
        };
    }
}
