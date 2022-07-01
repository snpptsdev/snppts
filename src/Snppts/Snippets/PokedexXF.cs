using Snppts.Authors;
using Snppts.Extensions;
using Snppts.Infrastructure;
using System;
using System.Collections.Generic;

namespace Snppts.Snippets
{
    public class PokedexXF : IAmASnippet
    {
        public string Slug => "pokedexXF";
        public string Title => "Pokedex XF";
        public string Description => "App developed with XamarinForms to search for pokémons, filtering by types, in addition to viewing more information about the characters.";
        public GitHubRepoInfo GitHubRepoInfo => new GitHubRepoInfo("ErickSilva2605/xamarinforms-pokedex");
        public Uri ExternalUri => null;
        public bool ContainsAndroidSample => true;
        public bool ContainsiOSSample => true;
        public bool ContainsUWPSample => false;

        public IAmAnAuthor AuthorInfo => new ErickAugusto();

        public IEnumerable<Uri> ImageUris => new List<Uri>
        {
            new Uri("https://raw.githubusercontent.com/ErickSilva2605/xamarinforms-pokedex/main/Images/Android/Gifs/HomePage.gif"),
            new Uri("https://raw.githubusercontent.com/ErickSilva2605/xamarinforms-pokedex/main/Images/Android/Screenshots/HomePage.jpeg"),
            new Uri("https://raw.githubusercontent.com/ErickSilva2605/xamarinforms-pokedex/main/Images/Android/Screenshots/Generations.jpeg"),
            new Uri("https://raw.githubusercontent.com/ErickSilva2605/xamarinforms-pokedex/main/Images/Android/Screenshots/Sort.jpeg"),
            new Uri("https://raw.githubusercontent.com/ErickSilva2605/xamarinforms-pokedex/main/Images/Android/Screenshots/Filters.jpeg"),
            new Uri("https://raw.githubusercontent.com/ErickSilva2605/xamarinforms-pokedex/main/Images/Android/Screenshots/Details_About.jpeg"),
            new Uri("https://raw.githubusercontent.com/ErickSilva2605/xamarinforms-pokedex/main/Images/Android/Screenshots/Details_Stats.jpeg"),
            new Uri("https://raw.githubusercontent.com/ErickSilva2605/xamarinforms-pokedex/main/Images/Android/Screenshots/Details_Evolution.jpeg"),
            new Uri("https://raw.githubusercontent.com/ErickSilva2605/xamarinforms-pokedex/main/Images/Android/Gifs/Generations.gif"),
            new Uri("https://raw.githubusercontent.com/ErickSilva2605/xamarinforms-pokedex/main/Images/Android/Gifs/Sort.gif"),
            new Uri("https://raw.githubusercontent.com/ErickSilva2605/xamarinforms-pokedex/main/Images/Android/Gifs/SortGeneration.gif"),
            new Uri("https://raw.githubusercontent.com/ErickSilva2605/xamarinforms-pokedex/main/Images/Android/Gifs/Search.gif"),
            new Uri("https://raw.githubusercontent.com/ErickSilva2605/xamarinforms-pokedex/main/Images/Android/Gifs/Details.gif")

        };

        public IList<Category> Categories => new List<Category>
        {
            Category.CARDS,
            Category.FILTER,
            Category.PHOTOS,
            Category.LAUNCHSCREEN,
            Category.LISTS,
            Category.SEARCH,
            Category.TABBARS
        };
    }
}
