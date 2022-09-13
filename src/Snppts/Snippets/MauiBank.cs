namespace Snppts.Snippets;

public class MauiBank : IAmASnippet
{
    public string Slug => "dotnet-maui-bank";
    public string Title => ".NET MAUI Bank app";
    public bool ContainsAndroidSample => true;
    public bool ContainsiOSSample => true;
    public bool ContainsUWPSample => true;
    public Sdk BuiltWith => Sdk.Maui;

    public string Description => "Replicate Monobank design.";

    public IAmAnAuthor AuthorInfo => new VladislavAntonyuk();

    public IEnumerable<Uri> ImageUris => new List<Uri>
    {
        //new Uri("https://vladislavantonyuk.sirv.com/vladislavantonyuk/articles/dotnet-maui-bank.svg"),
        new Uri("https://camo.githubusercontent.com/dfe2ebb45ee5071331ddd836f4048d545d67ec0644eeb0f9d5b2a615abdd0cf5/68747470733a2f2f766c616469736c6176616e746f6e79756b2e736972762e636f6d2f766c616469736c6176616e746f6e79756b2f61727469636c65732f32332f646f746e65742d6d6175692d62616e6b2d6170702e676966")

    };

    public IList<Category> Categories => new List<Category>
    {
        Category.APPCLONE, Category.CARDS, Category.LOGIN, Category.SHOPPINGCART
    };

    public GitHubRepoInfo GitHubRepoInfo => new GitHubRepoInfo("VladislavAntonyuk/MauiSamples/tree/main/MauiBank");

    public Uri ExternalUri => null;
}
