using System;
using System.Collections.Generic;
using Snppts.Authors;
using Snppts.Infrastructure;

public class LibVLCSharp : IAmASnippet
{
    public string Slug => "LibVLCSharp";
    public string Title => "LibVLCSharp";
    public string GithubRepoName => "videolan/libvlcsharp";
    public bool ContainsAndroidSample => true;
    public bool ContainsiOSSample => true;
    public bool ContainsUWPSample => true;

    public string Description => "LibVLCSharp is a cross-platform audio and video API for .NET platforms based on VideoLAN's LibVLC Library. It provides a comprehensive multimedia API that can be used across mobile, server and desktop to render video and output audio as well as encode and stream.";

    public IAmAnAuthor AuthorInfo => new Martz();
    
    public Uri ExternalUri => new Uri("https://mfkl.github.io/libvlc/crossplatform/xamarin/forms/2019/08/13/MediaPlayerElement-Plug-and-play-LibVLCSharp-UI-video-control.html");

    public IEnumerable<Uri> ImageUris => new List<Uri>
    {
        new Uri("https://i.imgur.com/tULTEwS.png"),
        new Uri("https://i.imgur.com/HpnPsO7.png"),
        new Uri("https://i.imgur.com/ZR4WjMq.png")
    };

    public IList<Category> Categories => new List<Category>
    {
        Category.PLAYBACK
    };
}
