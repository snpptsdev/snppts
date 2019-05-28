using System;
using System.Collections.Generic;
using Snppts.Authors;
using Snppts.Infrastructure;

namespace Snppts.Snippets
{
    public class PinBasedLogin : IAmASnippet
    {
        public string Slug => "pin-based-login";
        public string Title => "PIN-based Login";
        public string GithubRepoName => "snpptsdev/Snppts.PinBasedLogin";
        public bool ContainsAndroidSample => true;
        public bool ContainsiOSSample => true;
        public bool ContainsUWPSample => false;

        public string Description => "This snippet was created to demonstrate a simple PIN-based login screen. It uses buttons and images to create the numpad control. Tapping on a number adds the number to a property bound to the interface. Also contains some simple length checks (max. 6 characters) for the PIN code and uses Fresh MVVM for its page models.";

        public IAmAnAuthor AuthorInfo => new StevenThewissen();

        public IEnumerable<Uri> ImageUris => new List<Uri>
        {
            new Uri("https://raw.githubusercontent.com/snpptsdev/MigratedImages/master/18/60.jpg"),
            new Uri("https://raw.githubusercontent.com/snpptsdev/MigratedImages/master/18/61.jpg")
        };

        public IList<Category> Categories => new List<Category>
        {
            Category.LOGIN
        };
    }
}
