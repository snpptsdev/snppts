using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using NUnit.Framework;
using Snppts.Infrastructure;

namespace Snppts.Tests.Snippets;

public class SnippetsTests
{
    private const string GITHUB_BASE_URL = "https://github.com";
    private IEnumerable<Type> _types;
    private readonly HttpClient _httpClient = new HttpClient();

    [SetUp]
    public void SetUp()
    {
        _types = typeof(Program).Assembly
            .GetLoadableTypes()
            .Where(x => typeof(IAmASnippet).IsAssignableFrom(x))
            .Where(x => !x.IsInterface);
    }

    [Test]
    public async Task RepositoriesShouldBeReachable()
    {
        foreach (var type in _types)
        {
            var snippetInstance = Activator.CreateInstance(type) as IAmASnippet;
            var repositoryUri = $"{GITHUB_BASE_URL}/{snippetInstance.GitHubRepoInfo.GitHubRepoName}";

            var statusCode = await GetStatusCodeFromUri(repositoryUri);

            Assert.That(statusCode, Is.EqualTo(HttpStatusCode.OK), $"{repositoryUri} is not reachable");
        }
    }

    [Test]
    public async Task InvalidRepositoryShouldBeNotFound()
    {
        var invalidUri = $"{GITHUB_BASE_URL}/invalid/repository-for-testing";

        var statusCode = await GetStatusCodeFromUri(invalidUri);

        Assert.That(statusCode, Is.EqualTo(HttpStatusCode.NotFound));
    }

    [Test]
    public async Task ImagesShouldBeReachable()
    {
        foreach (var type in _types)
        {
            var snippetInstance = Activator.CreateInstance(type) as IAmASnippet;
            foreach (var uri in snippetInstance.ImageUris)
            {
                var statusCode = await GetStatusCodeFromUri(uri);

                Assert.That(statusCode, Is.EqualTo(HttpStatusCode.OK), $"Image {uri} is not reachable");
            }
        }
    }

    private Task<HttpStatusCode> GetStatusCodeFromUri(string uri)
    {
        return GetStatusCodeFromUri(new Uri(uri));
    }

    private async Task<HttpStatusCode> GetStatusCodeFromUri(Uri uri)
    {
        try
        {
            var response = await _httpClient.SendAsync(new HttpRequestMessage(HttpMethod.Head, uri));

            if (response.StatusCode == HttpStatusCode.TooManyRequests)
            {
                await TestContext.Out.WriteLineAsync("Hit HTTP 429, trying to get retry-after value...");

                var delay = response.Headers.RetryAfter.Delta ?? TimeSpan.FromSeconds(10);
                
                await TestContext.Out.WriteLineAsync($"Waiting for {delay.Seconds}");
                await Task.Delay(delay.Seconds);
                
                return await GetStatusCodeFromUri(uri);
            }

            return response.StatusCode;
        }
        catch (HttpRequestException exception)
        {                
            throw new Exception($"Exception for URL {uri} Message: {exception.Message}", exception);
        }
    }
}
