using System;
using Snppts.Infrastructure;

namespace Snppts.Authors
{
    public class Martz : IAmAnAuthor
    {
        public string FirstName => "Martz";
        public string LastName => "";
        public Uri Website => new Uri("https://mfkl.github.io");
        public string TwitterHandle => "martz2804";
        public string GitHubHandle => "mfkl";
        public string GravatarHash => "b5d00fd00b366a1d846bfebaebffbd08";
    }
}