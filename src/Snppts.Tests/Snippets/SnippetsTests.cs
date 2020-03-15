﻿using System;
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
                var repositoryUrl = $"{GITHUB_BASE_URL}/{snippetInstance.GithubRepoName}";

                var statusCode = GetStatusCodeFromUrl(repositoryUrl);

                Assert.AreEqual(HttpStatusCode.OK, statusCode);
            }
        }

        [Test]
        public void InvalidRepositoryShouldBeNotFound()
        {
            var invalidUrl = $"{GITHUB_BASE_URL}/invalid/repository-for-testing";

            var statusCode = GetStatusCodeFromUrl(invalidUrl);

            Assert.AreEqual(HttpStatusCode.NotFound, statusCode);
        }

        private HttpStatusCode GetStatusCodeFromUrl(string url)
        {
            try
            {
                var request = WebRequest.Create(url);
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
