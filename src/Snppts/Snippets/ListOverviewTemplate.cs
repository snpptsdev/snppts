using Snppts.Authors;
using Snppts.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Snppts.Snippets
{
    public class ListOverviewTemplate : IAmASnippet
    {
        public string Slug => "Listview-Item-Template";
        public string Title => "Listview General Item Template";
        public string GithubRepoName => "ListViewTemplate";
        public bool ContainsAndroidSample => true;
        public bool ContainsiOSSample => true;
        public bool ContainsUWPSample => false;

        public string Description => "Listview template for displaying item image and details";

        public IAmAnAuthor AuthorInfo => new PatrickGoode();

        public IEnumerable<Uri> ImageUris => new List<Uri>
        {
            new Uri("http://patrickgoode.com/wp-content/uploads/2019/11/screenshot-1573237095029.jpg"),
           
        };

        public IList<Category> Categories => new List<Category>
        {
             Category.LISTS
        };

        public Uri ExternalUri => new Uri("https://github.com/attrib75/ListViewTemplate");
    }
}
