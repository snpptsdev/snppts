using System;
using Snppts.Infrastructure;

namespace Snppts.Authors
{
    public class CharlinAgramonte : IAmAnAuthor
    {
        public string FirstName => "Charlin";
        public string LastName => "Agramonte";
        public Uri Website => new Uri("https://xamgirl.com/");
        public string TwitterHandle => "Chard003";
        public string GitHubHandle => "CrossGeeks";
        public string GravatarHash => "7db2bb2eed17e8df7e78b0d5461d90b0";
    }
}
