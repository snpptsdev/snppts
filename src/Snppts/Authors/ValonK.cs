using System;
using Snppts.Infrastructure;

namespace Snppts.Authors
{
    public class ValonK : IAmAnAuthor
    {
        public string FirstName => "Valon";
        public string LastName => "Kastrati";
        public Uri Website { get; }
        public string TwitterHandle => "vkcodez";
        public string GitHubHandle => "ValonK";
        public string GravatarHash { get; }
    }
}
