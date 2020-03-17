using System;
using System.Collections.Generic;
using Snppts.Authors;
using Snppts.Extensions;
using Snppts.Infrastructure;

namespace Snppts.Snippets
{
    public class WhatsAppChatList : IAmASnippet
    {
        public string Slug => "whatsapp-chat-list";
        public string Title => "WhatsApp Chat List";

        public string Description => "Inspired in WhatsApp, a simple chat list implementation using ListView with ViewCells. Some details about implementation: ListView was made with DataTemplateSelector " +
        	"for single messages and group messages. Rounded images use FFImageLoading with circle transformation. For iOS, a render for ViewCell was made for add cell accessory and make margin adjustments " +
        	"in separator inset. To show correct colours of the badges, was created color in resource dictionary with different values for each platform. To show correct date time information, was created " +
        	"a converter to parse DateTime object and transform in string.";

        public GitHubRepoInfo GitHubRepoInfo => new GitHubRepoInfo("ionixjunior/xamarin-forms-interfaces");

        public bool ContainsAndroidSample => true;
        public bool ContainsiOSSample => true;
        public bool ContainsUWPSample => false;

        public IAmAnAuthor AuthorInfo => new IoneSouzaJunior();

        public IEnumerable<Uri> ImageUris => new List<Uri>
        {
            new Uri("https://raw.githubusercontent.com/snpptsdev/MigratedImages/master/137/164.jpg"),
            new Uri("https://raw.githubusercontent.com/snpptsdev/MigratedImages/master/137/165.jpg")
        };

        public IList<Category> Categories => new List<Category>
        {
            Category.MESSAGING
        };

        public Uri ExternalUri => null;
    }
}
