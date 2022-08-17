using System;
using System.Collections.Generic;
using Snppts.Authors;
using Snppts.Extensions;
using Snppts.Infrastructure;

namespace Snppts.Snippets
{
    public class DuolingoClone : IAmASnippet
    {
        public string Slug => "duolingo-clone";
        public string Title => "Duolingo Clone";
        public string Description => "A clone of the Duolingo app made with Xamarin.Forms. At moment, this app contains the lessons, stories, profile, ranking, store, the tab bar structure and custom navigation bar for each page. Some custom renderers was created for the floating action button in Android, tab bar and circular / horizontal progress bar.";
        public GitHubRepoInfo GitHubRepoInfo => new GitHubRepoInfo("ionixjunior/XFAppDuolingoClone");
        public Uri ExternalUri => new Uri("https://www.ionixjunior.com.br/duolingo-app-clone-com-xamarin-forms/");
        public bool ContainsAndroidSample => true;
        public bool ContainsiOSSample => true;
        public bool ContainsUWPSample => false;
        public Sdk BuiltWith => Sdk.XamarinForms;

        public IAmAnAuthor AuthorInfo => new IoneSouzaJunior();

        public IEnumerable<Uri> ImageUris => new List<Uri>
        {
            new Uri("https://raw.githubusercontent.com/ionixjunior/XFAppDuolingoClone/master/art/android_lessons_1.png"),
            new Uri("https://raw.githubusercontent.com/ionixjunior/XFAppDuolingoClone/master/art/android_lessons_2.png"),
            new Uri("https://raw.githubusercontent.com/ionixjunior/XFAppDuolingoClone/master/art/android_lessons_3.png"),
            new Uri("https://raw.githubusercontent.com/ionixjunior/XFAppDuolingoClone/master/art/android_stories_1.png"),
            new Uri("https://raw.githubusercontent.com/ionixjunior/XFAppDuolingoClone/master/art/android_stories_2.png"),
            new Uri("https://raw.githubusercontent.com/ionixjunior/XFAppDuolingoClone/master/art/android_profile_1.png"),
            new Uri("https://raw.githubusercontent.com/ionixjunior/XFAppDuolingoClone/master/art/android_profile_2.png"),
            new Uri("https://raw.githubusercontent.com/ionixjunior/XFAppDuolingoClone/master/art/android_profile_3.png"),
            new Uri("https://raw.githubusercontent.com/ionixjunior/XFAppDuolingoClone/master/art/android_profile_4.png"),
            new Uri("https://raw.githubusercontent.com/ionixjunior/XFAppDuolingoClone/master/art/android_ranking_1.png"),
            new Uri("https://raw.githubusercontent.com/ionixjunior/XFAppDuolingoClone/master/art/android_store_1.png"),
            new Uri("https://raw.githubusercontent.com/ionixjunior/XFAppDuolingoClone/master/art/android_store_2.png"),
            new Uri("https://raw.githubusercontent.com/ionixjunior/XFAppDuolingoClone/master/art/ios_lessons_1.png"),
            new Uri("https://raw.githubusercontent.com/ionixjunior/XFAppDuolingoClone/master/art/ios_lessons_2.png"),
            new Uri("https://raw.githubusercontent.com/ionixjunior/XFAppDuolingoClone/master/art/ios_lessons_3.png"),
            new Uri("https://raw.githubusercontent.com/ionixjunior/XFAppDuolingoClone/master/art/ios_stories_1.png"),
            new Uri("https://raw.githubusercontent.com/ionixjunior/XFAppDuolingoClone/master/art/ios_profile_1.png"),
            new Uri("https://raw.githubusercontent.com/ionixjunior/XFAppDuolingoClone/master/art/ios_profile_2.png"),
            new Uri("https://raw.githubusercontent.com/ionixjunior/XFAppDuolingoClone/master/art/ios_profile_3.png"),
            new Uri("https://raw.githubusercontent.com/ionixjunior/XFAppDuolingoClone/master/art/ios_profile_4.png"),
            new Uri("https://raw.githubusercontent.com/ionixjunior/XFAppDuolingoClone/master/art/ios_ranking_1.png"),
            new Uri("https://raw.githubusercontent.com/ionixjunior/XFAppDuolingoClone/master/art/ios_store_1.png"),
            new Uri("https://raw.githubusercontent.com/ionixjunior/XFAppDuolingoClone/master/art/ios_store_2.png")
        };

        public IList<Category> Categories => new List<Category>
        {
            Category.DASHBOARD,
            Category.TABBARS,
            Category.APPCLONE,
            Category.LISTS
        };
    }
}
