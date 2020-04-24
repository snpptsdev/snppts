using Snppts.Authors;
using Snppts.Extensions;
using Snppts.Infrastructure;
using System;
using System.Collections.Generic;

namespace Snppts.Snippets
{
    public class GamesChipsUI : IAmASnippet
    {
        public string Slug => "xf-games-chips";
        public string Title => "XF Games Chips";
        public string Description => "Example project to show how to create so-called 'Chips' (without a plugin), used for data filtering, etc.";
        public GitHubRepoInfo GitHubRepoInfo => new GitHubRepoInfo("Altevir/xamarinforms-games-chips");
        public Uri ExternalUri => null;
        public bool ContainsAndroidSample => true;
        public bool ContainsiOSSample => true;
        public bool ContainsUWPSample => false;
        public IAmAnAuthor AuthorInfo => new AltevirCardosoNeto();

        public IEnumerable<Uri> ImageUris => new List<Uri>
        {
            new Uri("https://user-images.githubusercontent.com/11803107/80119193-c1523900-855f-11ea-864a-f44cb0c4a003.jpg"),
            new Uri("https://user-images.githubusercontent.com/11803107/80119227-cca56480-855f-11ea-8b44-e5c031d28428.PNG"),
            new Uri("https://user-images.githubusercontent.com/11803107/80120661-b698a380-8561-11ea-9faf-604dca45ff19.gif")
        };

        public IList<Category> Categories => new List<Category>
        {
            Category.LISTS,
            Category.PHOTOS,
        };
    }
}
