using Snppts.Infrastructure;
using System;

namespace Snppts.Authors
{
    public class ErickAugusto : IAmAnAuthor
    {
        public string FirstName => "Erick";
        public string LastName => "Augusto da Silva";
        public Uri Website => new Uri("https://www.linkedin.com/in/erick-augusto-silva/");
        public string TwitterHandle => "";
        public string GitHubHandle => "ErickSilva2605";
        public string EmailAddress => "erick.dev.it@gmail.com";
        public string GravatarHash => "";
    }
}
