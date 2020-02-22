using Snppts.Infrastructure;
using System;

namespace Snppts.Authors
{
    public class KodjoLaurentEgbakou : IAmAnAuthor
    {
        public string FirstName => "Kodjo Laurent";
        public string LastName => "Egbakou";
        public Uri Website => new Uri("https://lioncoding.com");
        public string TwitterHandle => "lioncoding";
        public string GitHubHandle => "egbakou";
        public string EmailAddress => "laurent@lioncoding.com";
        public string GravatarHash => "6e26a030d3b9495872b58d922bd86157";
    }
}
