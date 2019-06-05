using System;
using Snppts.Infrastructure;

namespace Snppts.Authors
{
    public class DanielJohnCauser : IAmAnAuthor
    {
        public string FirstName => "Daniel John";
        public string LastName => "Causer";
        public Uri Website => null;
        public string TwitterHandle => "danielcauser";
        public string GitHubHandle => "DanielCauser";
        public string GravatarHash => "2666956714a2c2d48c480a6bddac4071";
    }
}
