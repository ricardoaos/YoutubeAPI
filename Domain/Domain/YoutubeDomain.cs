using System;
using System.Collections.Generic;

namespace Domain
{
    public class YoutubeDomain
    {
        private IList<string> youtubeSearch;

        public YoutubeDomain(string search)
        {
            Search = search;
        }

        public string Search { get; private set; }
    }
}
