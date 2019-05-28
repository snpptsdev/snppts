using System;
namespace Snppts.Infrastructure
{
    public interface IAmAnAuthor
    {
        string FirstName { get; }
        string LastName { get; }
        Uri Website { get; }
        string TwitterHandle { get; }
        string GitHubHandle { get; }
        string GravatarHash { get; }
    }
}
