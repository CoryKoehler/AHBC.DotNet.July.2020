using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace Novemeber11thConsumingExternalApi.Service
{
    public interface ISearchlyService
    {
        Task<SearchlyResponse> GetSearchlyResults(string query);
    }

    public class SearchlyService : ISearchlyService
    {
        private readonly HttpClient _httpClient;
        private JsonSerializerOptions _options;


        //Documentation for Seachly https://searchly.asuarez.dev/docs/v1#operation/src.searchly.api.v1.controllers.song.search
        public SearchlyService(HttpClient httpClient)
        {
            _httpClient = httpClient;
            _options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true,
                WriteIndented = true
            };
        }

        public async Task<SearchlyResponse> GetSearchlyResults(string query)
        {
            //https://searchly.asuarez.dev/api/v1/song/search?query=michael%20jackson
            var response = await _httpClient.GetAsync($"song/search?query={query}");

            var jsonString = await response.Content.ReadAsStringAsync();
            //await response.Content.ReadAsAsync<SearchlyResponse>();

            var songlyResponse = JsonSerializer.Deserialize<SearchlyResponse>(jsonString, _options);

            return songlyResponse;
        }
    }

    public class SearchlyResponse
    {
        //      "error": false,
        //"response": {
        //    "results": [

        public bool Error { get; set; }
        public SearchlyInternalResponse Response { get; set; }
    }

    public class SearchlyInternalResponse
    {
        public List<SearchlyResult> Results { get; set; }
    }

    public class SearchlyResult
    {
        //"id": 34978,
        //      "name": "michael jackson - ain't no sunshine"
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
