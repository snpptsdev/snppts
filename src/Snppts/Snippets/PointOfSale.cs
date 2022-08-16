public class PointOfSale : IAmASnippet
{
    public string Slug => "point-of-sale";
    public string Title => "Point of Sale";
    public string GithubRepoName => "snpptsio/Snppts.PointOfSale";
    public bool ContainsAndroidSample => true;
    public bool ContainsiOSSample => true;
    public bool ContainsUWPSample => true;
    public bool ContainsmacOSSample => true;

    public string Description => "This snippet shows using .NET MAUI and a variety of community libraries to create a beautiful Point of Sale app suite featuring a desktop/tablet UI and mobile UI.";

    public IAmAnAuthor AuthorInfo => new DavidOrtinau();

    public IEnumerable<Uri> ImageUris => new List<Uri>
    {
        new Uri("https://user-images.githubusercontent.com/41873/183739194-0e19cb9c-71aa-490b-9e80-25ea1dc40ce0.png"),
        new Uri("https://user-images.githubusercontent.com/41873/183740348-7f55d10d-8f79-4ee0-a71e-64b317cbd64f.png")
    };

    public IList<Category> Categories => new List<Category>
    {
        Category.STORES
    };
}
