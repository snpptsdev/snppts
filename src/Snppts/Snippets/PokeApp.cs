using Snppts.Authors;
using Snppts.Extensions;
using Snppts.Infrastructure;
using System;
using System.Collections.Generic;

namespace Snppts.Snippets
{
    public class PokeApp : IAmASnippet
    {
        public string Slug => "poke-app";
        public string Title => "PokeApp";
        public GitHubRepoInfo GitHubRepoInfo => new GitHubRepoInfo("kainaalmeida/pokeapp");
        public bool ContainsAndroidSample => true;
        public bool ContainsiOSSample => true;
        public bool ContainsUWPSample => false;

        public string Description => "This snippet was created to demonstrate some animations and photos";

        public IAmAnAuthor AuthorInfo => new KainaAlmeida();

        public IEnumerable<Uri> ImageUris => new List<Uri>
        {   
            new Uri("https://raw.githubusercontent.com/kainaalmeida/pokeapp/master/Screenshots/splashAndroid.jpg"),
            new Uri("https://raw.githubusercontent.com/kainaalmeida/pokeapp/master/Screenshots/pokemonsAndroid.jpg"),
            new Uri("https://raw.githubusercontent.com/kainaalmeida/pokeapp/master/Screenshots/popupAndroid.jpg"),
            new Uri("https://raw.githubusercontent.com/kainaalmeida/pokeapp/master/Screenshots/galeriaAndroid.jpg"),
            new Uri("https://raw.githubusercontent.com/kainaalmeida/pokeapp/master/Screenshots/splash.png"),
            new Uri("https://raw.githubusercontent.com/kainaalmeida/pokeapp/master/Screenshots/pokemons.png"),
            new Uri("https://raw.githubusercontent.com/kainaalmeida/pokeapp/master/Screenshots/popup.png"),
            new Uri("https://raw.githubusercontent.com/kainaalmeida/pokeapp/master/Screenshots/galeria.png")
        };

        public IList<Category> Categories => new List<Category>
        {
            Category.LISTS,
            Category.PHOTOS,
            Category.CARDS
        };

        public Uri ExternalUri => null;
    }
}
