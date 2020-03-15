using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using NUnit.Framework;
using Snppts.Infrastructure;

namespace Snppts.Tests.Snippets
{
    public class SnippetsTests
    {
        private const string GITHUB_BASE_URL = "https://github.com";
        private IEnumerable<Type> _types;

        [SetUp]
        public void SetUp()
        {
            _types = typeof(Program).Assembly
                .GetLoadableTypes()
                .Where(x => typeof(IAmASnippet).IsAssignableFrom(x))
                .Where(x => !x.IsInterface);
        }

        [Test]
        public void RepositoriesShouldBeReachable()
        {
            foreach (var type in _types)
            {
                var snippetInstance = Activator.CreateInstance(type) as IAmASnippet;
                var repositoryUri = $"{GITHUB_BASE_URL}/{snippetInstance.GithubRepoName}";

                var statusCode = GetStatusCodeFromUri(repositoryUri);

                Assert.AreEqual(HttpStatusCode.OK, statusCode);
            }
        }

        [Test]
        public void InvalidRepositoryShouldBeNotFound()
        {
            var invalidUri = $"{GITHUB_BASE_URL}/invalid/repository-for-testing";

            var statusCode = GetStatusCodeFromUri(invalidUri);

            Assert.AreEqual(HttpStatusCode.NotFound, statusCode);
        }

        private HttpStatusCode GetStatusCodeFromUri(string uri)
        {
            try
            {
                var request = WebRequest.Create(uri);
                request.Method = "HEAD";
                var response = request.GetResponse() as HttpWebResponse;
                return response.StatusCode;
            }
            catch (WebException webException)
            {
                return ((HttpWebResponse)webException.Response).StatusCode;
            }
        }
    }
}
