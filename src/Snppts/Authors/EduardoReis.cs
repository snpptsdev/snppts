using System;
namespace Snppts.Authors
{
    public class EduardoReis : IAmAnAuthor
    {
        public string FirstName => "Eduardo";

        public string LastName => "Reis";

        public Uri Website => new Uri("https://github.com/EduardoReisDev");

        public string TwitterHandle => "eduardoreisdev";

        public string GitHubHandle => "EduardoReisDev";

        public string GravatarHash => "46c2df2c699e7324f56b258811edcf5a";
    }
}

