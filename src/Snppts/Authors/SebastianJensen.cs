using Snppts.Infrastructure;
using System;

namespace Snppts.Authors
{
    public class SebastianJensen : IAmAnAuthor
    {
        public string FirstName => "Sebastian";

        public string LastName => "Jensen";

        public Uri Website => new Uri("https://www.tsjdev-apps.de");

        public string TwitterHandle => "tsjdevapps";

        public string GitHubHandle => "tsjdev-apps";

        public string GravatarHash => "d990a05a189c263901ca94367d3a50be";
    }
}
