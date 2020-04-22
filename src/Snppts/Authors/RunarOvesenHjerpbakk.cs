using System;
using Snppts.Infrastructure;

namespace Snppts.Authors
{
    public class RunarOvesenHjerpbakk : IAmAnAuthor
    {
        public string FirstName => "Runar Ovesen";
        public string LastName => "Hjerpbakk";
        public Uri Website => new Uri("https://hjerpbakk.com");
        public string TwitterHandle => "hjerpbakk";
        public string GitHubHandle => "sankra";
        public string GravatarHash => "62b1d11eafee92745a51971d6cc21f85";
    }
}
