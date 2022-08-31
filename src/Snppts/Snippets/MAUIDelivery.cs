namespace Snppts.Snippets
{
     public class MauiDelivery : IAmASnippet
     {
          public string Slug => "maui-delivery";
          public string Title => "MAUIDelivery";
          public GitHubRepoInfo GitHubRepoInfo => new GitHubRepoInfo("hprez21/MAUIDelivery");
          public bool ContainsAndroidSample => true;
          public bool ContainsiOSSample => true;
          public bool ContainsUWPSample => false;
          public Sdk BuiltWith => Sdk.Maui;

          public string Description => "A beautiful example of a Delivery App created with a lot of features of .NET MAUI, like shadows, frames, borders, animations, etc.";

          public IAmAnAuthor AuthorInfo => new HectorPerez();

          public IEnumerable<Uri> ImageUris => new List<Uri>
    {
        new Uri("https://user-images.githubusercontent.com/9836726/187585035-1c943f33-d881-4572-977c-d560ae84c755.jpg")
    };

          public IList<Category> Categories => new List<Category>
    {
        Category.STORES
    };

          public Uri ExternalUri => new Uri("https://devs.school/how-was-the-mauidelivery-application-created/");
     }
}
