namespace Snppts.Authors;

public class JeanMarieParent : IAmAnAuthor
{
    public string FirstName => "Jean-Marie";

    public string LastName => "Parent";

    public Uri Website => new Uri("https://www.jmparent.com/");

    public string TwitterHandle => "jmparent_dev";

    public string GitHubHandle => "jm-parent";

    public string GravatarHash => "d1d50caf99e1b66ab2c3bd82cf265f7f";
}
