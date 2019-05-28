using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Snppts.Infrastructure;
using X.PagedList;

namespace Snppts.Controllers
{
    public class HomeController : BaseController
    {
        private readonly IAmASnippet[] _snippets;

        public HomeController(IEnumerable<IAmASnippet> snippets)
        {
            _snippets = snippets.ToArray();
        }

        [Route("")]
        public IActionResult Index(int? page)
        {
            var pageNumber = page ?? 1;
            var viewModel = _snippets.ToPagedList(pageNumber, 9);

            return View(viewModel);
        }

        [Route("about")]
        public IActionResult About()
        {
            return View();
        }

        [Route("how-to-contribute")]
        public IActionResult Contributing()
        {
            return View();
        }

        //[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        //public IActionResult Error()
        //{
        //    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        //}
    }
}
