using System;
using Snppts.Infrastructure;

namespace Snppts.Authors
{
    public class ShawYu : IAmAnAuthor
    {
        public string FirstName => "Shaw";
        public string LastName => "Yu";
        public Uri Website => new Uri("https://www.youtube.com/channel/UCmgk0PHlIvJ6TYt54VUEgHQ");
        public string TwitterHandle => "shawyunz";
        public string GitHubHandle => "shawyunz";
        public string GravatarHash => "aae1466b6e1a7a850d961fe13dbf4ad9";
    }
}
