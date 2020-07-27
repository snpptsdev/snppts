using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Snppts.Infrastructure;

namespace Snppts.ViewComponents
{
    public class RandomSnippetsViewComponent : ViewComponent
    {
        private readonly IEnumerable<IAmASnippet> _snippets;

        public RandomSnippetsViewComponent(IEnumerable<IAmASnippet> snippets)
        {
            _snippets = snippets.ToArray();
        }

        public IViewComponentResult Invoke()
        {
            var random = new Random();
            var snippets = _snippets.OrderBy(x => random.Next()).Take(3).ToList();

            return View(snippets);
        }
    }
}
