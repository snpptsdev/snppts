namespace Snppts.Snippets;

public class NFTWallet : IAmASnippet
{
    public string Slug => "NFTWallet";
    public string Title => "NFT Marketplace";
    public string Description => "Example of an NFT Marketplace. The app brings together cryptocurrency artists, creators and enthusiasts on a single platform to create and trade the best NFTs in a fictitious way. All data displayed in the app is fictitious.";
    public GitHubRepoInfo GitHubRepoInfo => new GitHubRepoInfo("ErickSilva2605/xamarinforms-nft-wallet");
    public Uri ExternalUri => null;
    public bool ContainsAndroidSample => true;
    public bool ContainsiOSSample => true;
    public bool ContainsUWPSample => false;
    public Sdk BuiltWith => Sdk.XamarinForms;

    public IAmAnAuthor AuthorInfo => new ErickAugusto();

    public IEnumerable<Uri> ImageUris => new List<Uri>
    {
        new Uri("https://raw.githubusercontent.com/ErickSilva2605/xamarinforms-nft-wallet/main/Images/Android/Gifs/full.gif"),
        new Uri("https://raw.githubusercontent.com/ErickSilva2605/xamarinforms-nft-wallet/main/Images/Android/Screenshots/Dark/home.jpeg"),
        new Uri("https://raw.githubusercontent.com/ErickSilva2605/xamarinforms-nft-wallet/main/Images/Android/Screenshots/Light/home.jpeg"),
        new Uri("https://raw.githubusercontent.com/ErickSilva2605/xamarinforms-nft-wallet/main/Images/Android/Screenshots/Dark/trends.jpeg"),
        new Uri("https://raw.githubusercontent.com/ErickSilva2605/xamarinforms-nft-wallet/main/Images/Android/Screenshots/Light/trends.jpeg"),
        new Uri("https://raw.githubusercontent.com/ErickSilva2605/xamarinforms-nft-wallet/main/Images/Android/Screenshots/Dark/wallet.jpeg"),
        new Uri("https://raw.githubusercontent.com/ErickSilva2605/xamarinforms-nft-wallet/main/Images/Android/Screenshots/Light/wallet.jpeg"),
        new Uri("https://raw.githubusercontent.com/ErickSilva2605/xamarinforms-nft-wallet/main/Images/Android/Screenshots/Dark/profile_grid.jpeg"),
        new Uri("https://raw.githubusercontent.com/ErickSilva2605/xamarinforms-nft-wallet/main/Images/Android/Screenshots/Light/profile_grid.jpeg"),
        new Uri("https://raw.githubusercontent.com/ErickSilva2605/xamarinforms-nft-wallet/main/Images/Android/Screenshots/Dark/configuration.jpeg"),
        new Uri("https://raw.githubusercontent.com/ErickSilva2605/xamarinforms-nft-wallet/main/Images/Android/Screenshots/Light/configuration.jpeg"),
        new Uri("https://raw.githubusercontent.com/ErickSilva2605/xamarinforms-nft-wallet/main/Images/Android/Gifs/change_langage.gif"),
        new Uri("https://raw.githubusercontent.com/ErickSilva2605/xamarinforms-nft-wallet/main/Images/Android/Gifs/change_theme.gif"),
    };

    public IList<Category> Categories => new List<Category>
    {
        Category.CARDS,
        Category.FILTER,
        Category.PHOTOS,
        Category.LISTS,
        Category.SEARCH,
        Category.TABBARS,
        Category.CHARTS,
        Category.LOGIN,
        Category.PROFILES,
        Category.SETTINGS
    };
}
