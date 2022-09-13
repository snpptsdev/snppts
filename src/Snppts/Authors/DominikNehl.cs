namespace Snppts.Authors;

public class DominikNehl : IAmAnAuthor
{
    public string FirstName => "Dominik";

    public string LastName => "Nehl";

    public Uri Website => new Uri("https://www.nehl-it.com");

    public string TwitterHandle => string.Empty;

    public string GitHubHandle => "dnehl";

    public string GravatarHash => "8f0c7bda579c0865ddebfd65dc073015";
}
