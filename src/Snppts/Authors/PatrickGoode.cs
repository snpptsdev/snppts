using Snppts.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Snppts.Authors
{
    public class PatrickGoode : IAmAnAuthor
    {
        public string FirstName => "Patrick";
        public string LastName => "Goode";
        public Uri Website => new Uri("http://patrickgoode.com/");
        public string TwitterHandle => "PatrickGoode";
        public string GitHubHandle => "attrib75";
        public string EmailAddress => "pgoode75@sbcglobal.net";
        public string GravatarHash => "c24f10a93ab9762963ad27206655fea2";
    }
}
