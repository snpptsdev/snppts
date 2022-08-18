public class StarbucksRedisgn : IAmASnippet
{
  public string Slug => "maui-starbucks-redesign";
  public string Title => "Maui Starbuck Redesign";
  public GitHubRepoInfo GitHubRepoInfo => new GitHubRepoInfo("sattasundar/maui-starbucks-ui");
  public bool ContainsAndroidSample => true;
  public bool ContainsiOSSample => false;
  public bool ContainsUWPSample => false;
  public Sdk BuiltWith => Sdk.Maui;

  public string Description => "StarbucksRedesign App UI build in all new .NET MAUI ";

  public IAmAnAuthor AuthorInfo => new SattaSundar();

  public IEnumerable<Uri> ImageUris => new List<Uri>
  {
      new Uri("https://raw.githubusercontent.com/sattasundar/maui-starbucks-ui/main/images/android_home.png"),
      new Uri("https://raw.githubusercontent.com/sattasundar/maui-starbucks-ui/main/images/android_detail.png"),
      new Uri("https://raw.githubusercontent.com/sattasundar/maui-starbucks-ui/main/images/android_splash.png"),
      new Uri("https://raw.githubusercontent.com/sattasundar/maui-starbucks-ui/main/images/ios_home.png"),
      new Uri("https://raw.githubusercontent.com/sattasundar/maui-starbucks-ui/main/images/ios_detail.png"),
      new Uri("https://raw.githubusercontent.com/sattasundar/maui-starbucks-ui/main/images/mac_home.png"),
      new Uri("https://raw.githubusercontent.com/sattasundar/maui-starbucks-ui/main/images/mac_detail.png"),
  };

  public IList<Category> Categories => new List<Category>
  {
    Category.PRODUCTS
  };

  public Uri ExternalUri => new Uri("https://github.com/sattasundar/maui-starbucks-ui");
}
