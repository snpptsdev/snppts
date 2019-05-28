<img src="https://raw.githubusercontent.com/snpptsdev/snppts/master/src/Snppts/wwwroot/img/snppts_logo.png" width="300px" />

# Welcome

Hi! Welcome to Snppts.dev!

If you create cool UIs in Xamarin, this is the place to be! You're welcome to add your created UIs and become part of our ever-growing library of content! Please keep in mind that what you are sharing does not violate the community [code of conduct](https://github.com/snpptsdev/snppts/blob/master/CODE_OF_CONDUCT.md).

# Add yourself as an author

To add yourself as a Snppts author you can fork this project, add yourself to the [authors folder](https://github.com/snpptsdev/snppts/tree/master/src/Snppts/Authors) as a class, implementing the `IAmAnAuthor` interface.

The result should look something like this:

``` csharp
public class StevenThewissen : IAmAnAuthor
{
    public string FirstName => "Steven";
    public string LastName => "Thewissen";
    public Uri Website => new Uri("https://www.thewissen.io");
    public string TwitterHandle => "devnl";
    public string GitHubHandle => "sthewissen";
    public string EmailAddress => "steven@thewissen.io";
    public string GravatarHash => "62ce0e69389e31fd3c42fb230f9b1637";
}
```

A few pointers:

- Name the class after your first and lastname with PascalCase.
- The `FirstName` and `LastName` property should resemble that same name.
- `EmailAddress`, `TwitterHandle` and`GitHubHandle` should be pretty clear, `TwitterHandle` without the leading @.
- The `Website` property can be your global website or whatever you want people to look at.
- If you want to show your Gravatar go to https://en.gravatar.com/site/check/ and get your hash! If you don't fill the hash, you will be viewed as a silhouette.

# Add your first snippet

To add a snippet you can fork this project, add your snippet to the [Snippets folder](https://github.com/snpptsdev/snppts/tree/master/src/Snppts/Snippets) as a class, implementing the `IAmASnippet` interface.

The result should look something like this:

``` csharp
public class PinBasedLogin : IAmASnippet
{
    public string Slug => "pin-based-login";
    public string Title => "PIN-based Login";
    public string GithubRepoName => "snpptsio/Snppts.PinBasedLogin";
    public bool ContainsAndroidSample => true;
    public bool ContainsiOSSample => true;
    public bool ContainsUWPSample => false;

    public string Description => "This snippet was created to demonstrate a simple PIN-based login screen. It uses buttons and images to create the numpad control. Tapping on a number adds the number to a property bound to the interface. Also contains some simple length checks (max. 6 characters) for the PIN code and uses Fresh MVVM for its page models.";

    public IAmAnAuthor AuthorInfo => new StevenThewissen();

    public IEnumerable<Uri> ImageUris => new List<Uri>
    {
        new Uri("https://raw.githubusercontent.com/snpptsio/MigratedImages/master/18/60.jpg"),
        new Uri("https://raw.githubusercontent.com/snpptsio/MigratedImages/master/18/61.jpg")
    };

    public IList<Category> Categories => new List<Category>
    {
        Category.LOGIN
    };
}
```

A few pointers:

- Name the class after the title of your snippet with PascalCase.
- Provide a slug where your creation should be permalinked on Snppts.
- Link your `IAmAnAuthor` object by creating a new instance of it. This allows you to post more snippets in the future!
- Choose one or more appropriate categories for your creation. If there's no existing category that fits your creation you're allowed to add one but it will be reviewed upon submitting your PR.
- With `ImageUris` you can supply one or more URIs showing off screenshots of your creation. Please make sure that these screenshots are all of a single screen, so no compilations.

# Just Xamarin please

This site is dedicated to Xamarin, so samples in Swift, Java, Objective-C and the likes will not be accepted. Since we will be looking at each PR we will reject any that are not about Xamarin.

# The last step...

And it truly is a big step for monkeykind 🐵! Last thing that remains is submit a Pull Request to us and whenever it gets merged party 🎉! You're on Snppts now!

![Featured on Snppts Badge](https://www.snppts.dev/img/snppts-badge.jpg)

Don't forget to incorporate the Featured on Snppts badge on your blog and link back to us! Enjoy all of our great content! Of course you are more than welcome to submit other features and bugfixes as well.

# Acknowledgements
* Thanks to [PlanetXamarin](https://www.planetxamarin.com) for the inspiration on how to create Snppts.
* Thanks to [our awesome contributors](https://github.com/snpptsdev/snppts/graphs/contributors) and our [community of authors](https://github.com/snpptsdev/snppts/tree/master/src/Snppts/Authors) who make this all possible.
