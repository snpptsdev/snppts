using Microsoft.AspNetCore.Mvc;

namespace Snppts.ViewComponents;

public class PopularCategoriesViewComponent : ViewComponent
{
    private readonly IEnumerable<IAmASnippet> _snippets;

    public PopularCategoriesViewComponent(IEnumerable<IAmASnippet> snippets)
    {
        _snippets = snippets.ToArray();
    }

    public IViewComponentResult Invoke()
    {
        var categories = _snippets.Select(x => x.Categories).SelectMany(i => i);
        var groupedSorted = categories.GroupBy(n => n).OrderByDescending(g => g.Count());
        var categoriesFinal = groupedSorted.Take(10).Select(x => x.FirstOrDefault()).ToList();

        return View(categoriesFinal);
    }
}
