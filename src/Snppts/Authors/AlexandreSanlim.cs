using Snppts.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Snppts.Authors
{
    public class AlexandreSanlim : IAmAnAuthor
    {
        public string FirstName => "Alexandre";

        public string LastName => "Sanlim";

        public Uri Website => null;

        public string TwitterHandle => "alexandresanlim";

        public string GitHubHandle => "alexandresanlim";

        public string GravatarHash => "201e2428b23bfe48fbb3e02e54f6652d";
    }
}
