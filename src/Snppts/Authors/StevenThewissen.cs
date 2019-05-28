using System;
using Snppts.Infrastructure;

namespace Snppts.Authors
{
    public class StevenThewissen : IAmAnAuthor
    {
        public string FirstName => "Steven";
        public string LastName => "Thewissen";
        public Uri Website => new Uri("https://www.thewissen.io");
        public string TwitterHandle => "devnl";
        public string GitHubHandle => "sthewissen";
        public string GravatarHash => "62ce0e69389e31fd3c42fb230f9b1637";
    }
}
