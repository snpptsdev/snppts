namespace Snppts.Snippets;

public class TodoMe : IAmASnippet
{
    public string Slug => "TodoMe";

    public string Title => "Todo.me";

    public string Description => "Todo.me is a simple note taking and task tracking app made with .NET MAUI.";

    public GitHubRepoInfo GitHubRepoInfo => new GitHubRepoInfo("behl1anmol/Todo.me");

    public Uri ExternalUri => null;

    public bool ContainsAndroidSample => true;

    public bool ContainsiOSSample => false;

    public bool ContainsUWPSample => false;

    public Sdk BuiltWith => Sdk.Maui;

    public IAmAnAuthor AuthorInfo => new AnmolBehl();

    public IEnumerable<Uri> ImageUris => new List<Uri>
    {
        new Uri("https://raw.githubusercontent.com/behl1anmol/Todo.me/master/Screenshots/Maui_app_todo.gif"),
        new Uri("https://raw.githubusercontent.com/behl1anmol/Todo.me/master/Screenshots/TodoView.jpg"),
        new Uri("https://raw.githubusercontent.com/behl1anmol/Todo.me/master/Screenshots/TodoDetailsView.jpg")
    };

    public IList<Category> Categories => new List<Category>
    {
        Category.LISTS,
        Category.NAVIGATIONS,
        Category.ACTIVITYFEEDS
    };
}
