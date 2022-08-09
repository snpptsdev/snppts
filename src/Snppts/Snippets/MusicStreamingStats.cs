using Snppts.Authors;
using Snppts.Extensions;
using Snppts.Infrastructure;
using System;
using System.Collections.Generic;

namespace Snppts.Snippets
{
    public class MusicStreamingStats : IAmASnippet
    {
        public string Slug => "music-streaming-stats";
        public string Title => "Music Streaming Stats";
        public GitHubRepoInfo GitHubRepoInfo => new GitHubRepoInfo("michaldivis/music-streaming-stats-ui");
        public bool ContainsAndroidSample => true;
        public bool ContainsiOSSample => true;
        public bool ContainsUWPSample => false;

        public string Description => "A simple music streaming stats dashboard app, similar to Spotify for Artists.";

        public IAmAnAuthor AuthorInfo => new MichalDivis();

        public IEnumerable<Uri> ImageUris => new List<Uri>
        {
            new Uri("https://github.com/michaldivis/music-streaming-stats-ui/blob/master/screenshots/android_1.png?raw=true"),
            new Uri("https://github.com/michaldivis/music-streaming-stats-ui/blob/master/screenshots/android_2.png?raw=true"),
            new Uri("https://github.com/michaldivis/music-streaming-stats-ui/blob/master/screenshots/ios_1.png?raw=true"),
            new Uri("https://github.com/michaldivis/music-streaming-stats-ui/blob/master/screenshots/ios_2.png?raw=true"),
        };

        public IList<Category> Categories => new List<Category>
        {
            Category.DASHBOARD
        };

        public Uri ExternalUri => null;
    }
}
