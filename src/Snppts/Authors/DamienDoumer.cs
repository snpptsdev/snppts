using Snppts.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Snppts.Authors
{
    public class DamienDoumer : IAmAnAuthor
    {
        public string FirstName => "Damien";
        public string LastName => "Doumer";
        public Uri Website => new Uri("https://doumer.me");
        public string TwitterHandle => "Damien_Doumer";
        public string GitHubHandle => "damiendoumer";
        public string EmailAddress => "dtohin@outlook.fr";
        public string GravatarHash => "ecdd93df62c61daa04da17967f82d08d";
    }
}
