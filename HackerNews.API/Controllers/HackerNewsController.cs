using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HackerNews.API.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace HackerNews.API.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class HackerNewsController : ControllerBase
    {
        private readonly IHackerNewsRepository _repo;
        
        public HackerNewsController(IHackerNewsRepository repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public async Task<IActionResult> GetNewStories()
        {
            var newStories = await _repo.GetNewStories();
            
            return Ok(newStories);
        }
    }
}