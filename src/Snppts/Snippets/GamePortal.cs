namespace Snppts.Snippets;

public class GamePortal : IAmASnippet
{
    public string Slug => "soferity-game-portal";
    public string Title => "Soferity: Game Portal";
    public string Description => "Soferity: Game Portal is a game hub. It allows you to have a fun and good time with the various types of games it offers.";
    public GitHubRepoInfo GitHubRepoInfo => new GitHubRepoInfo("Soferity/GamePortal");
    public bool ContainsAndroidSample => true;
    public bool ContainsiOSSample => true;
    public bool ContainsUWPSample => true;
    public Uri ExternalUri => new Uri("https://www.microsoft.com/store/apps/9P1JZMGT34M2");
    public Sdk BuiltWith => Sdk.Maui;

    public IAmAnAuthor AuthorInfo => new Taiizor();

    public IEnumerable<Uri> ImageUris => new List<Uri>
    {
        //English
        new Uri("https://raw.githubusercontent.com/Soferity/GamePortal/develop/.screenshots/Home.EN.png"),
        new Uri("https://github.com/Soferity/GamePortal/raw/develop/.screenshots/TheCube.EN.png"),
        new Uri("https://github.com/Soferity/GamePortal/raw/develop/.screenshots/ValorousRabbit.EN.png"),
        new Uri("https://github.com/Soferity/GamePortal/raw/develop/.screenshots/TowerBlock.EN.png"),
        new Uri("https://github.com/Soferity/GamePortal/raw/develop/.screenshots/SweetMemory.EN.png"),
        new Uri("https://github.com/Soferity/GamePortal/raw/develop/.screenshots/TowerOfHanoi.EN.png"),
        new Uri("https://github.com/Soferity/GamePortal/raw/develop/.screenshots/TheAviator.EN.png"),

        //Spanish
        new Uri("https://raw.githubusercontent.com/Soferity/GamePortal/develop/.screenshots/Home.ES.png"),
        new Uri("https://github.com/Soferity/GamePortal/raw/develop/.screenshots/TheCube.ES.png"),
        new Uri("https://github.com/Soferity/GamePortal/raw/develop/.screenshots/ValorousRabbit.ES.png"),
        new Uri("https://github.com/Soferity/GamePortal/raw/develop/.screenshots/TowerBlock.ES.png"),
        new Uri("https://github.com/Soferity/GamePortal/raw/develop/.screenshots/SweetMemory.ES.png"),
        new Uri("https://github.com/Soferity/GamePortal/raw/develop/.screenshots/TowerOfHanoi.ES.png"),
        new Uri("https://github.com/Soferity/GamePortal/raw/develop/.screenshots/TheAviator.ES.png"),

        //Turkish
        new Uri("https://raw.githubusercontent.com/Soferity/GamePortal/develop/.screenshots/Home.TR.png"),
        new Uri("https://github.com/Soferity/GamePortal/raw/develop/.screenshots/TheCube.TR.png"),
        new Uri("https://github.com/Soferity/GamePortal/raw/develop/.screenshots/ValorousRabbit.TR.png"),
        new Uri("https://github.com/Soferity/GamePortal/raw/develop/.screenshots/TowerBlock.TR.png"),
        new Uri("https://github.com/Soferity/GamePortal/raw/develop/.screenshots/SweetMemory.TR.png"),
        new Uri("https://github.com/Soferity/GamePortal/raw/develop/.screenshots/TowerOfHanoi.TR.png"),
        new Uri("https://github.com/Soferity/GamePortal/raw/develop/.screenshots/TheAviator.TR.png")
    };

    public IList<Category> Categories => new List<Category>
    {
        Category.GAMES
    };
}