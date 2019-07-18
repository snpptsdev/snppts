using System;
using Snppts.Infrastructure;

namespace Snppts.Authors
{
    public class JeanMarieAlfonsi : IAmAnAuthor
    {
        public string FirstName => "Jean-Marie";
        public string LastName => "Alfonsi";
        public Uri Website => new Uri("https://www.sharpnado.com");
        public string TwitterHandle => "piskariov";
        public string GitHubHandle => "roubachof";
        public string GravatarHash => "793803979d0ef8d047e83c86fd2ad67f";
    }
}
