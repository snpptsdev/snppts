using System;
using Snppts.Infrastructure;

namespace Snppts.Authors
{
    public class ShahrukhYousafzai : IAmAnAuthor
    {
        public string FirstName => "Shahrukh";
        public string LastName => "Yousafzai";
        public Uri Website => new Uri("https://srkyousafzaipk.github.io/AboutMe/");
        public string TwitterHandle => "SRKYousafzaiPK";
        public string GitHubHandle => "SRKYousafzaiPK";
        public string EmailAddress => "shahrukhhkhan2003@gmail.com";
        public string GravatarHash => "c3517b5c29751c62ff1d2198f21c20ba";
    }
}
