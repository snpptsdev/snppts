using Snppts.Infrastructure;
using System;

namespace Snppts.Authors
{
    public class IeuanWalker : IAmAnAuthor
    {
        public string FirstName => "Ieuan";
        public string LastName => "Walker";
        public Uri Website => new Uri("https://ieuanwalker.com");
        public string TwitterHandle => "IeuanTWalker";
        public string GitHubHandle => "IeuanWalker";
        public string GravatarHash => "08d06d47d752c87ed40544362581cda1";
    }
}
