using Snppts.Extensions;
using System;
using System.Collections.Generic;

namespace Snppts.Infrastructure
{
    public interface IAmASnippet
    {
        string Slug { get; }

        string Title { get; }

        string Description { get; }

        GitHubRepoInfo GitHubRepoInfo { get; }
        Uri ExternalUri { get; }
        bool ContainsAndroidSample { get; }
        bool ContainsiOSSample { get; }
        bool ContainsUWPSample { get; }

        IAmAnAuthor AuthorInfo { get; }
        IEnumerable<Uri> ImageUris { get; }
        IList<Category> Categories { get; }
    }

    public enum Category
    {
        ABOUT = 1,
        ACTIVITYFEEDS = 2,
        CALCULATORS = 3,
        CALENDARSTIME = 4,
        CARDS = 5,
        CHARTS = 6,
        COMMENTS = 7,
        DASHBOARD = 8,
        FILTER = 9,
        FRIENDS = 10,
        LAUNCHSCREEN = 11,
        LISTS = 12,
        LOGIN = 13,
        MAPS = 14,
        MESSAGING = 15,
        NAVIGATIONS = 16,
        NOTIFICATIONS = 17,
        PHOTOS = 18,
        PLAYBACK = 19,
        POPOVERS = 20,
        PRODUCTS = 21,
        PROFILES = 22,
        SEARCH = 23,
        SETTINGS = 24,
        SHARE = 25,
        SHOPPINGCART = 26,
        SIDEBARS = 27,
        SIGNUPS = 28,
        TABBARS = 29,
        TIMELINE = 30,
        WALKTHROUGHS = 31,
        WIDGETS = 32,
        DATAGRID = 33,
        APPCLONE = 34,
        ARTICLES = 35,
        ERRORS = 36,
        STORES = 37,
        NEOMORPHISM = 38
    }
}