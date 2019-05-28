using System;
using System.Web;
using Snppts.Infrastructure;

namespace Snppts.Extensions
{
 public static class GravatarHashingExtensions
    {
        public static string GravatarImage(this IAmAnAuthor member)
        {
            const int size = 200;

            var hash = member.GravatarHash;

            //var defaultImage = HttpUtility.UrlEncode();  // TODO: ConfigurationManager.AppSettings["DefaultGravatarImage"]);

            return $"//www.gravatar.com/avatar/{hash}.jpg?s={size}";  // &d={defaultImage}";
        }
    }
}
