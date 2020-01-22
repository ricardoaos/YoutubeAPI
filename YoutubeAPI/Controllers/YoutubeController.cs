using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Service.Contracts;
using YoutubeAPI.Dto;

namespace YoutubeAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class YoutubeController : ControllerBase
    {
        private readonly IYoutubeService youtubeService;
        private readonly IMapper mapper;

        public YoutubeController(IYoutubeService youtubeService, IMapper mapper)
        {
            this.youtubeService = youtubeService;
            this.mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> Search(string search)
        {
            return Ok(await youtubeService.Search(search));
        }
    }
}