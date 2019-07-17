using System;
using Snppts.Infrastructure;

namespace Snppts.Authors
{
    public class DanielMonettelli : IAmAnAuthor
    {
        public string FirstName => "Daniel A.";
        public string LastName => "Monettelli L.";
        public Uri Website => new Uri("https://www.youtube.com/c/danielmonetelli");
        public string TwitterHandle => "DanielMonetelli";
        public string GitHubHandle => "monetelli";
        public string EmailAddress => "danielmonetelli@hotmail.com";
        public string GravatarHash => "4b3d0e60019ad8fe1e4d7cd5c8850efb";
    }
}
