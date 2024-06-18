

namespace Snppts.Snippets;

public class AuthenticatorClone : IAmASnippet
{
    public string Slug => "microsoft-authenticator-clone";

    public string Title => "Microsoft Authenticator Clone";

    public string Description => "A clone of the Microsoft Authenticator app. At the moment, the app contains the splash screen, new account screen, list of accounts, and verification of IDs";

    public GitHubRepoInfo GitHubRepoInfo => new GitHubRepoInfo("salesHgabriel/AuthenticatorClone-");

    public Uri ExternalUri => null;

    public bool ContainsAndroidSample => true;

    public bool ContainsiOSSample => false;

    public bool ContainsUWPSample => false;

    public Sdk BuiltWith => Sdk.Maui;

    public IAmAnAuthor AuthorInfo => new GabrielSales();

    public IEnumerable<Uri> ImageUris => new List<Uri>
    {
        new Uri("https://raw.githubusercontent.com/salesHgabriel/AuthenticatorClone-/master/art/splashscreen.png"),
        new Uri("https://raw.githubusercontent.com/salesHgabriel/AuthenticatorClone-/master/art/tela_authenticator.png"),
        new Uri("https://raw.githubusercontent.com/salesHgabriel/AuthenticatorClone-/master/art/tela_idsverificados.png"),
    };

    public IList<Category> Categories => new List<Category>
    {
        Category.PROFILES,
        Category.APPCLONE,
        Category.LISTS
    };
}
