using System;
using Snppts.Infrastructure;

namespace Snppts.Authors
{
    public class RicardoPrestes : IAmAnAuthor
    {
        public string FirstName => "Ricardo";
        public string LastName => "Prestes";
        public Uri Website => null;
        public string TwitterHandle => "ricardo_prestes";
        public string GitHubHandle => "ricardoprestes";
        public string EmailAddress => "ricardo.logan@hotmail.com";
        public string GravatarHash => "9802e38d5bd2cd85db8b0720d5feed29";
    }
}
