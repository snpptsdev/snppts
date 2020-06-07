using Snppts.Infrastructure;
using System;

namespace Snppts.Authors
{
    public class AmaroManungu : IAmAnAuthor
    {
        public string FirstName => "Amaro";
        public string LastName => "Manungu";
        public Uri Website => new Uri("https://www.linkedin.com/in/amaro-manungu-729837162");
        public string TwitterHandle => "amaro_manungu";
        public string GitHubHandle => "Amaro96";
        public string EmailAddress => "amarotati@outlook.pt";
        public string GravatarHash => "2f4e0baf3efd3c1d497e79f5af9c399c";
    }
}
