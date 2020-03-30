﻿using System;
using System.Collections.Generic;
using Snppts.Authors;
using Snppts.Extensions;
using Snppts.Infrastructure;

namespace Snppts.Snippets
{
    public class SoundCloudClone : IAmASnippet
    {
        public string Slug => "soundcloud-clone";
        public string Title => "SoundCloud Clone";
        public string Description => "A clone of the SoundCloud app made with Xamarin.Forms. At moment, this app contains the albums and streamings screen only.";

        public GitHubRepoInfo GitHubRepoInfo => new GitHubRepoInfo("ionixjunior/SoundCloudClone");

        public Uri ExternalUri => new Uri("https://www.youtube.com/playlist?list=PL6M6J_6V_um8IzRN4lgRUEWrPWC6iQfiq");
        public bool ContainsAndroidSample => true;
        public bool ContainsiOSSample => true;
        public bool ContainsUWPSample => false;

        public IAmAnAuthor AuthorInfo => new IoneSouzaJunior();

        public IEnumerable<Uri> ImageUris => new List<Uri>
        {
            new Uri("https://raw.githubusercontent.com/ionixjunior/SoundCloudClone/master/art/android_home_1.png"),
            new Uri("https://raw.githubusercontent.com/ionixjunior/SoundCloudClone/master/art/android_stream_1.png"),
            new Uri("https://raw.githubusercontent.com/ionixjunior/SoundCloudClone/master/art/ios_home_1.png"),
            new Uri("https://raw.githubusercontent.com/ionixjunior/SoundCloudClone/master/art/ios_stream_1.png")
        };

        public IList<Category> Categories => new List<Category>
        {
            Category.APPCLONE,
            Category.LISTS,
            Category.TABBARS,
            Category.ACTIVITYFEEDS
        };
    }
}
