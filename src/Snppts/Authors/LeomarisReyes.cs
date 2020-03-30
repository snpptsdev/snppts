using System;
using Snppts.Infrastructure;

namespace Snppts.Authors
{
    public class LeomarisReyes : IAmAnAuthor
    {
        public string FirstName => "Leomaris";
        public string LastName => "Reyes";
        public Uri Website => new Uri("https://AskXammy.com/");
        public string TwitterHandle => "leomarisreyes11";
        public string GitHubHandle => "leomarisreyes";
        public string EmailAddress => "lreyes@stemelle.com";
        public string GravatarHash => "ae78e84a683611c7b72c9ba829c125e0";
    }
}
