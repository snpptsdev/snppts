using System;
using Snppts.Infrastructure;

namespace Snppts.Authors
{
    public class RadekVymetalik : IAmAnAuthor
    {
        public string FirstName => "Radek";
        public string LastName => "Vymětalík";
        public Uri Website => new Uri("https://github.com/RadekVyM");
        public string TwitterHandle => "";
        public string GitHubHandle => "RadekVyM";
        public string EmailAddress => "rvymetalik@email.cz";
        public string GravatarHash => "";
    }
}
