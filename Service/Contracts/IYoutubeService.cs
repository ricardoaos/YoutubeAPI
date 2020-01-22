using Domain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Service.Contracts
{
    public interface IYoutubeService
    {
        Task<IEnumerable<dynamic>> Search(string search);
    }
}
