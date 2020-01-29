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
                searchListRequest.Q = search;
                searchListRequest.MaxResults = 50;

                var searchListResponse = await searchListRequest.ExecuteAsync();

                return searchListResponse.Items;
            }
            catch (Exception e)
            {

                throw e;
            }
        }
    }
}
