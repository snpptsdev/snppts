using System;
using Snppts.Infrastructure;

namespace Snppts.Authors
{
    public class VladislavAntonyuk : IAmAnAuthor
    {
        public string FirstName => "Vladislav";
        public string LastName => "Antonyuk";
        public Uri Website => new Uri("https://vladislavantonyuk.azurewebsites.net/");
        public string TwitterHandle => string.Empty;
        public string GitHubHandle => "VladislavAntonyuk";
        public string GravatarHash => "c0b401631d8b65318905a76d8c643bad";
    }
}
