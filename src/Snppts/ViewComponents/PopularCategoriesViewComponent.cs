using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Snppts.Infrastructure;

namespace Snppts.ViewComponents
{
    public class PopularCategoriesViewComponent : ViewComponent
    {
        private readonly IEnumerable<IAmASnippet> _snippets;

        public PopularCategoriesViewComponent(IEnumerable<IAmASnippet> snippets)
        {
            _snippets = snippets.ToArray();
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var categories = _snippets.Select(x => x.Categories).SelectMany(i => i);
            var groupedSorted = categories.GroupBy(n => n).OrderByDescending(g => g.Count());
            var categoriesFinal = groupedSorted.Take(10).Select(x => x.FirstOrDefault()).ToList();

            return View(categoriesFinal);
        }
    }
}
