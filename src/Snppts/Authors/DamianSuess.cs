using Snppts.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Snppts.Authors
{
    public class DamianSuess : IAmAnAuthor
    {
        public string FirstName => "Damian";
        public string LastName => "Suess";
        public Uri Website => new Uri("https://suesslabs.com");
        public string TwitterHandle => "";
        public string GitHubHandle => "DamianSuess";
        public string EmailAddress => "noreply@email.com";
        public string GravatarHash => "5e39caab2d1ae3cf43efb99a2bfd4d4b";
    }
}
