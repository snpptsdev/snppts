using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Snppts.Infrastructure;

namespace Snppts.ViewComponents
{
    public class AllCategoriesViewComponent : ViewComponent
    {
        private readonly IEnumerable<IAmASnippet> _snippets;

        public AllCategoriesViewComponent(IEnumerable<IAmASnippet> snippets)
        {
            _snippets = snippets.ToArray();
        }

        public IViewComponentResult Invoke()
        {
            var categories = _snippets.Select(x => x.Categories).SelectMany(i => i);
            var groupedSorted = categories.GroupBy(n => n).OrderBy(g => g.FirstOrDefault().ToString());
            var categoriesFinal = groupedSorted.Select(x => x.FirstOrDefault()).ToList();

            return View(categoriesFinal);
        }
    }
}