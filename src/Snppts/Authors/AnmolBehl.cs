using static System.Net.WebRequestMethods;

namespace Snppts.Authors;

public class AnmolBehl : IAmAnAuthor
{
    public string FirstName => "Anmol";
    public string LastName => "Behl";
    public Uri Website => new Uri("https://www.nerdpitch.me/");
    public string TwitterHandle => "behl1anmol";
    public string GitHubHandle => "behl1anmol";
    public string GravatarHash => "d76775c90c17ab76a8d52e9d5e1ee069";
}
