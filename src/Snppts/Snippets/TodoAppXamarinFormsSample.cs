namespace Snppts.Snippets;

public class TodoAppXamarinFormsSample : IAmASnippet
{
    public string Slug => "todo-app-xamarin-forms";
    public string Title => "Todo App in Xamarin.Forms";
    public string Description => "This snippet was created to demonstrate a well structured Xamarin.Forms MVVM application. It uses feature-based, clean architecture and levarages all built-in MAUI controls.";
    public GitHubRepoInfo GitHubRepoInfo => new GitHubRepoInfo("tuyen-vuduc/todo-app-xamarin-forms");
    public bool ContainsAndroidSample => true;
    public bool ContainsiOSSample => true;
    public bool ContainsUWPSample => false;
    public Uri ExternalUri => new Uri("https://github.com/tuyen-vuduc/todo-app-xamarin-forms");
    public Sdk BuiltWith => Sdk.XamarinForms;

    public IAmAnAuthor AuthorInfo => new TuyenVuDuc();

    public IEnumerable<Uri> ImageUris => new List<Uri>
    {
        new Uri("https://raw.githubusercontent.com/tuyen-vuduc/todo-app-xamarin-forms/master/docs/images/home-with-todos.png"),
        new Uri("https://raw.githubusercontent.com/tuyen-vuduc/todo-app-xamarin-forms/master/docs/images/home-delete.png"),
        new Uri("https://raw.githubusercontent.com/tuyen-vuduc/todo-app-xamarin-forms/master/docs/images/home-empty.png"),
        new Uri("https://raw.githubusercontent.com/tuyen-vuduc/todo-app-xamarin-forms/master/docs/images/home-sidebar.png"),
        new Uri("https://raw.githubusercontent.com/tuyen-vuduc/todo-app-xamarin-forms/master/docs/images/new-todo.png"),
        new Uri("https://raw.githubusercontent.com/tuyen-vuduc/todo-app-xamarin-forms/master/docs/images/new-todo-filled.png"),
    };

    public IList<Category> Categories => new List<Category>
    {
        Category.NAVIGATIONS,
        Category.CHARTS,
        Category.SIDEBARS,
        Category.LISTS,
        Category.DASHBOARD,
    };
}