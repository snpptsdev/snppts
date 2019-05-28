using System;
using Snppts.Infrastructure;

namespace Snppts.Authors
{
    public class JavierSuarezRuiz : IAmAnAuthor
    {
        public string FirstName => "Javier";
        public string LastName => "Suárez Ruiz";
        public Uri Website => new Uri("https://javiersuarezruiz.wordpress.com/");
        public string TwitterHandle => "jsuarezruiz";
        public string GitHubHandle => "jsuarezruiz";
        public string GravatarHash => "dfe5d4830ab6c49995c24f8bc290437c";
    }
}
