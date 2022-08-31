using System;
namespace Snppts.Authors
{
	public class UmeshKamble : IAmAnAuthor
    {
        public string FirstName => "Umesh";
        public string LastName => "Kamble";
        public Uri Website => new Uri("https://github.com/umeshkamble");
        public string TwitterHandle => "umeshkamble1984";
        public string GitHubHandle => "umeshkamble";
        public string EmailAddress => "ukamble6@gmail.com";
        public string GravatarHash => "";
    }
}

