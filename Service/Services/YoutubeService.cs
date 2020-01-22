using Domain;
using Google.Apis.Services;
using Google.Apis.YouTube.v3;
using Repository;
using Service.Contracts;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Service
{
    public class YoutubeService : IYoutubeService
    {
        private readonly IYoutubeRepository repository;

        public YoutubeService(IYoutubeRepository repository)
        {
            this.repository = repository;
        }

        public async Task<IEnumerable<dynamic>> Search(string search)
        {
            try
            {
                var youtubeService = new YouTubeService(new BaseClientService.Initializer()
                {
                    ApiKey = "AIzaSyBW6-V3uKGUMAp9dvdhdpTTcCMmyqSPNsg",
                    ApplicationName = this.GetType().ToString()
                });

                var searchListRequest = youtubeService.Search.List("snippet");
                searchListRequest.Q = search; // Replace with your search term.
                searchListRequest.MaxResults = 50;

                // Call the search.list method to retrieve results matching the specified query term.

                var searchListResponse = await searchListRequest.ExecuteAsync();

                List<string> videos = new List<string>();
                List<string> channels = new List<string>();
                List<string> playlists = new List<string>();

                // Add each result to the appropriate list, and then display the lists of
                // matching videos, channels, and playlists.
                foreach (var searchResult in searchListResponse.Items)
                {
                    switch (searchResult.Id.Kind)
                    {
                        case "youtube#video":
                            videos.Add(String.Format("{0} ({1})", searchResult.Snippet.Title, searchResult.Id.VideoId));
                            break;

                        case "youtube#channel":
                            channels.Add(String.Format("{0} ({1})", searchResult.Snippet.Title, searchResult.Id.ChannelId));
                            break;

                        case "youtube#playlist":
                            playlists.Add(String.Format("{0} ({1})", searchResult.Snippet.Title, searchResult.Id.PlaylistId));
                            break;
                    }
                }

                Console.WriteLine(String.Format("Videos:\n{0}\n", string.Join("\n", videos)));
                Console.WriteLine(String.Format("Channels:\n{0}\n", string.Join("\n", channels)));
                Console.WriteLine(String.Format("Playlists:\n{0}\n", string.Join("\n", playlists)));

                return null;
            }
            catch (Exception e)
            {

                throw e;
            }
        }
    }
}
