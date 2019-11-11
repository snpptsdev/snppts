using System;
using Snppts.Infrastructure;

namespace Snppts.Authors
{
    public class FelipeBaltazar : IAmAnAuthor
    {
        public string FirstName => "Felipe";
        public string LastName => "Baltazar";
        public Uri Website => new Uri("https://medium.com/@felipedasilvabaltazar");
        public string TwitterHandle => "FelippeBaltazar";
        public string GitHubHandle => "felipebaltazar";
        public string GravatarHash => "c4deac62305f590fbda80209628afd0e";
    }
}
