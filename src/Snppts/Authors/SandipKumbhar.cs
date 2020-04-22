using Snppts.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Snppts.Authors
{
    
    public class SandipKumbhar : IAmAnAuthor
    {
        public string FirstName => "Sandip";
        public string LastName => "Kumbhar";
        public Uri Website => new Uri("http://devoirtech.com/");
        public string TwitterHandle => "devoirtechIT";
        public string GitHubHandle => "devoirtechsandip";
        public string GravatarHash => "a97e280022876564d97bff2d333de8db";
    }
}
