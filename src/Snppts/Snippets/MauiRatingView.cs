namespace Snppts.Snippets;

public class MauiRatingView : IAmASnippet
{
    public string Slug => "maui-rating-view";
    public string Title => "Rating View Control using Maui.Graphics";
    public GitHubRepoInfo GitHubRepoInfo => new GitHubRepoInfo("naweed/Maui.Controls.RatingView");
    public bool ContainsAndroidSample => true;
    public bool ContainsiOSSample => true;
    public bool ContainsUWPSample => true;
    public bool ContainsmacOSSample => true;
    public Sdk BuiltWith => Sdk.Maui;

    public string Description => "A simple and customizable Rating View control for use with .NET MAUI Apps. Built using Maui.Graphics.";

    public IAmAnAuthor AuthorInfo => new NaweedAkram();

    public IEnumerable<Uri> ImageUris => new List<Uri>
    {
        new Uri("https://github.com/naweed/Maui.Controls.RatingView/blob/main/RattingScreenShot.png?raw=true")
    };

    public IList<Category> Categories => new List<Category>
    {
        Category.WIDGETS
    };

    public Uri ExternalUri => new Uri("https://blogs.xgenoapps.com/post/2022/07/03/rating-view-maui");
}
