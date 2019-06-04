using System;
using System.Collections.Generic;
using Snppts.Authors;
using Snppts.Infrastructure;

namespace Snppts.Snippets
{
    public class SpotifyClone : IAmASnippet
    {
        public string Slug => "spotify-clone";
        public string Title => "Spotify Clone";
        public string GithubRepoName => "sthewissen/KickassUI.Spotify";
        public bool ContainsAndroidSample => true;
        public bool ContainsiOSSample => true;
        public bool ContainsUWPSample => false;

        public string Description => "A Xamarin.Forms version of the Spotify app to prove you can create goodlooking UI with Xamarin.Forms as talked about in my blogpost on: <a href=\"https://www.thewissen.io/xamarin-forms-ui-spotify\" target=\"_blank\">https://www.thewissen.io/xamarin-forms-ui-spotify</a>";

        public IAmAnAuthor AuthorInfo => new StevenThewissen();

        public IEnumerable<Uri> ImageUris => new List<Uri>
        {
            new Uri("https://raw.githubusercontent.com/sthewissen/KickassUI.Spotify/master/images/spotify1.jpg"),
            new Uri("https://raw.githubusercontent.com/sthewissen/KickassUI.Spotify/master/images/spotify2.jpg"),
            new Uri("https://raw.githubusercontent.com/sthewissen/KickassUI.Spotify/master/images/spotify3.jpg"),
            new Uri("https://raw.githubusercontent.com/sthewissen/KickassUI.Spotify/master/images/spotify4.jpg")
        };

        public IList<Category> Categories => new List<Category>
        {
            Category.PLAYBACK, Category.LISTS, Category.DASHBOARD
        };
    }
}
