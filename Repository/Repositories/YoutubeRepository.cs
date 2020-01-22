using Domain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repositories
{
    public class YoutubeRepository : IYoutubeRepository
    {
        private readonly IConnectionFactory connection;
        public YoutubeRepository(IConnectionFactory connection)
        {
            this.connection = connection;
        }
              

        public async Task<IEnumerable<YoutubeDomain>> GetSearch()
        {
            IList<YoutubeDomain> listYoutube = new List<YoutubeDomain>();
            
            return listYoutube;
        }
    }
}
