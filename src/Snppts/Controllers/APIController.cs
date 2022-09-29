//Added by Naweed Akram on 29-Sep-2022 to enable API on the website
//Sample API Calls:
/*
https://snppts.dev/api/v.1.0/snippets/latest
https://snppts.dev/api/v.1.0/snippets/top
https://snppts.dev/api/v.1.0/category/1
https://snppts.dev/api/v.1.0/author/naweed

https://localhost:44343/api/v.1.0/snippets/latest
https://localhost:44343/api/v.1.0/snippets/top
https://localhost:44343/api/v.1.0/category/1
https://localhost:44343/api/v.1.0/author/naweed
*/

using Microsoft.AspNetCore.Mvc;
using Snppts.Extensions;
using System;
using X.PagedList;

namespace Snppts.Controllers;

[Route("api/v.1.0")]
[ApiController]
public class APIController : BaseController
{
    private readonly IAmASnippet[] _snippets;
    private readonly int _pageSize = 60;

    public APIController(IEnumerable<IAmASnippet> snippets)
    {
        _snippets = snippets.ToArray();
    }

    [HttpGet("snippets/latest")]
    [ResponseCache(Duration = 3600, Location = ResponseCacheLocation.Any, VaryByQueryKeys = new string[] { "page" })]
    //Cached for 1 hour
    public async Task<IActionResult> GetLatestSnippets(int? page)
    {
        var pageNumber = page ?? 1;

        try
        {
            var snippets = (await _snippets.SortSnippets(SortType.updated, pageNumber, _pageSize))
                            .ToPagedList(pageNumber, _pageSize);

            return Ok(snippets);
        }
        catch (Exception ex)
        {
            return StatusCode(500, $"Snppts.Dev: A problem occured while handling your request. Please try agian later.{Environment.NewLine}Detailed Error Message is: {ex.Message}.");
        }
    }

    [HttpGet("snippets/top")]
    [ResponseCache(Duration = 3600, Location = ResponseCacheLocation.Any, VaryByQueryKeys = new string[] { "page" })]
    //Cached for 1 hour
    public async Task<IActionResult> GetTopRatedSnippets(int? page)
    {
        var pageNumber = page ?? 1;

        try
        {
            var snippets = (await _snippets.SortSnippets(SortType.stars, pageNumber, _pageSize))
                                    .ToPagedList(pageNumber, _pageSize);

            return Ok(snippets);
        }
        catch (Exception ex)
        {
            return StatusCode(500, $"Snppts.Dev: A problem occured while handling your request. Please try agian later.{Environment.NewLine}Detailed Error Message is: {ex.Message}.");
        }
    }

    [HttpGet("category/{id}")]
    [ResponseCache(Duration = 3600, Location = ResponseCacheLocation.Any, VaryByQueryKeys = new string[] { "id", "page" })]
    //Cached for 1 hour
    public async Task<IActionResult> GetSnippetsByCategory(int id, int? page)
    {
        var pageNumber = page ?? 1;

        try
        {
            var snippets = _snippets
                            .Where(x => x.Categories.Contains((Category)id))
                            .ToPagedList(pageNumber, _pageSize);

            return Ok(snippets);
        }
        catch (Exception ex)
        {
            return StatusCode(500, $"Snppts.Dev: A problem occured while handling your request. Please try agian later.{Environment.NewLine}Detailed Error Message is: {ex.Message}.");
        }
    }

    [HttpGet("author/{githubhandle}")]
    [ResponseCache(Duration = 3600, Location = ResponseCacheLocation.Any, VaryByQueryKeys = new string[] { "githubhandle", "page" })]
    //Cached for 1 hour
    public async Task<IActionResult> GetSnippetsByAuthor(string gitHubHandle, int? page)
    {
        var pageNumber = page ?? 1;

        try
        {
            var snippets = _snippets
                            .Where(x => x.AuthorInfo.GitHubHandle.ToLower().Equals(gitHubHandle.ToLower()))
                            .ToPagedList(pageNumber, _pageSize);

            return Ok(snippets);
        }
        catch (Exception ex)
        {
            return StatusCode(500, $"Snppts.Dev: A problem occured while handling your request. Please try agian later.{Environment.NewLine}Detailed Error Message is: {ex.Message}.");
        }
    }
}
