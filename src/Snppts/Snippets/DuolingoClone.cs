using System;
using System.Collections.Generic;
using Snppts.Authors;
using Snppts.Infrastructure;

namespace Snppts.Snippets
{
    public class DuolingoClone : IAmASnippet
    {
        public string Slug => "duolingo-clone";
        public string Title => "Duolingo Clone";
        public string Description => "A Duolingo clone app made with Xamarin.Forms. At moment, this app only contains the lessons page, the tab bar structure and custom navigation bar for each page. Some custom renders was created for the floating action button in Android, tab bar and circular progress bar.";
        public string GithubRepoName => "ionixjunior/XFAppDuolingoClone";
        public Uri ExternalUri => new Uri("https://www.ionixjunior.com.br/duolingo-app-clone-com-xamarin-forms/");
        public bool ContainsAndroidSample => true;
        public bool ContainsiOSSample => true;
        public bool ContainsUWPSample => false;

        public IAmAnAuthor AuthorInfo => new IoneSouzaJunior();

        public IEnumerable<Uri> ImageUris => new List<Uri>
        {
            new Uri("https://raw.githubusercontent.com/ionixjunior/XFAppDuolingoClone/master/art/android_lessons_1.png"),
            new Uri("https://raw.githubusercontent.com/ionixjunior/XFAppDuolingoClone/master/art/android_lessons_2.png"),
            new Uri("https://raw.githubusercontent.com/ionixjunior/XFAppDuolingoClone/master/art/android_lessons_3.png"),
            new Uri("https://raw.githubusercontent.com/ionixjunior/XFAppDuolingoClone/master/art/ios_lessons_1.png"),
            new Uri("https://raw.githubusercontent.com/ionixjunior/XFAppDuolingoClone/master/art/ios_lessons_2.png"),
            new Uri("https://raw.githubusercontent.com/ionixjunior/XFAppDuolingoClone/master/art/ios_lessons_3.png")
        };

        public IList<Category> Categories => new List<Category>
        {
            Category.DASHBOARD,
            Category.TABBARS
        };
    }
}
