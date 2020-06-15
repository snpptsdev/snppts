using System;
using Snppts.Infrastructure;

namespace Snppts.Authors
{
    public class VicenteGuzman : IAmAnAuthor
    {
        public string FirstName => "Vicente";
        public string LastName => "Guzmán";
        public Uri Website => new Uri("https://vicenteguzman.mx/");
        public string TwitterHandle => "luciomsp";
        public string GitHubHandle => "luciomsp";
        public string EmailAddress => "luciomsp@geeks.ms";
        public string GravatarHash => "72cce778aac0d6066a14225e90c30874";
    }
}