﻿namespace Snppts.Snippets;

public class MusicStreamingStats : IAmASnippet
{
    public string Slug => "music-streaming-stats";
    public string Title => "Music Streaming Stats";
    public GitHubRepoInfo GitHubRepoInfo => new GitHubRepoInfo("michaldivis/music-streaming-stats-ui");
    public bool ContainsAndroidSample => true;
    public bool ContainsiOSSample => true;
    public bool ContainsUWPSample => false;
    public Sdk BuiltWith => Sdk.Maui;

    public string Description => "A simple music streaming stats dashboard app, similar to Spotify for Artists.";

    public IAmAnAuthor AuthorInfo => new MichalDivis();

    public IEnumerable<Uri> ImageUris => new List<Uri>
    {
        new Uri("https://github.com/michaldivis/music-streaming-stats-ui/blob/master/screenshots/android.png?raw=true")
    };

    public IList<Category> Categories => new List<Category>
    {
        Category.DASHBOARD
    };

    public Uri ExternalUri => null;
}
