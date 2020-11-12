using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Novemeber11thConsumingExternalApi.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Novemeber11thConsumingExternalApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SongController : ControllerBase
    {
        private readonly ISearchlyService _searchlyService;

        public SongController(ISearchlyService searchlyService)
        {
            _searchlyService = searchlyService;
        }

        // GET: api/Song/query
        [HttpGet("{query}")]
        public async Task<ActionResult<List<Song>>> GetSongs(string query)
        {
           var songs = new List<Song>();
           var result = await _searchlyService.GetSearchlyResults(query);

            foreach (var searchlySong in result.Response.Results)
            {
                songs.Add(new Song() { Id = searchlySong.Id, Name = searchlySong.Name });
            };

            return songs;
        }
    }

    public class Song
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
