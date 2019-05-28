using System;
using Snppts.Infrastructure;

namespace Snppts.Authors
{
    public class KymPhillpotts : IAmAnAuthor
    {
        public string FirstName => "Kym";
        public string LastName => "Phillpotts";
        public Uri Website => new Uri("https://www.kymphillpotts.com");
        public string TwitterHandle => "kphillpotts";
        public string GitHubHandle => "kphillpotts";
        public string GravatarHash => "3218e66502c6f0836dfd0f02f210ba0b";
    }
}
