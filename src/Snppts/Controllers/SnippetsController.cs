using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Snppts.Infrastructure;
using X.PagedList;

namespace Snppts.Controllers
{
    public class SnippetsController : BaseController
    {
        private readonly IAmASnippet[] _snippets;

        public SnippetsController(IEnumerable<IAmASnippet> snippets)
        {
            _snippets = snippets.ToArray();
        }

        [Route("category/{id}")]
        public IActionResult Category(int id, int? page)
        {
            var pageNumber = page ?? 1;
            var viewModel = _snippets.Where(x => x.Categories.Contains((Category)id)).ToPagedList(pageNumber, 9);
            return View(viewModel);
        }

        [Route("author/{githubhandle}")]
        public IActionResult Author(string gitHubHandle, int? page)
        {
            var pageNumber = page ?? 1;
            var viewModel = _snippets.Where(x => x.AuthorInfo.GitHubHandle.ToLower().Equals(gitHubHandle.ToLower())).ToPagedList(pageNumber, 9);
            return View(viewModel);
        }

        [Route("random")]
        public IActionResult Random()
        {
            var random = new Random();
            var randomSnip = _snippets.OrderBy(x => random.Next()).FirstOrDefault();

            if (randomSnip != null)
                return RedirectToAction("Show", new { slug = randomSnip.Slug });

            // No luck, so back home.
            return RedirectToAction("Index", "Home");
        }

        [Route("snippet/{slug}")]
        public IActionResult Show(string slug)
        {
            var viewModel = _snippets.FirstOrDefault(x => x.Slug == slug);

            if (viewModel != null)
                return View(viewModel);

            // No luck, so back home.
            return RedirectToAction("Index", "Home");
        }
    }
}
