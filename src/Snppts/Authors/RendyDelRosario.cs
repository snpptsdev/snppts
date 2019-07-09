using System;
using Snppts.Infrastructure;

namespace Snppts.Authors
{
    public class RendyDelRosario : IAmAnAuthor
    {
        public string FirstName => "Rendy";
        public string LastName => "Del Rosario";
        public Uri Website => new Uri("https://xamboy.com/");
        public string TwitterHandle => "rdelrosario";
        public string GitHubHandle => "rdelrosario";
        public string EmailAddress => "rendy@crossgeeks.com";
        public string GravatarHash => "4bece0ce1c33e65177110bcb95688c68";
    }
}
