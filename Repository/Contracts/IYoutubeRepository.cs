using Domain;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Repository
{
    public interface IYoutubeRepository
    {
        Task<IEnumerable<YoutubeDomain>> GetSearch();
    }
}
