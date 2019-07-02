using System;
using Snppts.Infrastructure;

namespace Snppts.Authors
{
    public class AimoreSa : IAmAnAuthor
    {
        public string FirstName => "Aimoré";
        public string LastName => "Sá";
        public Uri Website => new Uri("https://aimore.github.io/");
        public string TwitterHandle => "Aimore_Sa";
        public string GitHubHandle => "aimore";
        public string EmailAddress => "aimoresc@gmail.com";
        public string GravatarHash => "0601a7c390df793c7b308ac36860fcf7";
    }
}
