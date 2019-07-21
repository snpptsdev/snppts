using System;
using Snppts.Infrastructure;

namespace Snppts.Authors
{
    public class LogeshPalani : IAmAnAuthor
    {
        public string FirstName => "Logesh ";
        public string LastName => "Palani";
        public Uri Website => new Uri("https://logeshpalani.blogspot.com/");
        public string TwitterHandle => "logeshpalani98";
        public string GitHubHandle => "logeshpalani98";
        public string GravatarHash => "14fd9ec21509b468c84abbed2e47384e";
    }
}