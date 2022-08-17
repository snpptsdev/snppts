using Snppts.Extensions;
using System;
using System.Collections.Generic;

namespace Snppts.Infrastructure
{
    public interface IAmASnippet
    {
        string Slug { get; }

        string Title { get; }

        string Description { get; }

        GitHubRepoInfo GitHubRepoInfo { get; }
        Uri ExternalUri { get; }
        bool ContainsAndroidSample { get; }
        bool ContainsiOSSample { get; }
        bool ContainsUWPSample { get; }
        Sdk BuiltWith { get; }

        IAmAnAuthor AuthorInfo { get; }
        IEnumerable<Uri> ImageUris { get; }
        IList<Category> Categories { get; }
    }
}