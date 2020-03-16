using System.Collections.Generic;
using System.Threading.Tasks;
using System.Net.Http;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using HackerNews.API.Dtos;
using System;

namespace HackerNews.API.Helpers
{
    public interface IHackerNewsClient
    {
        Task<IEnumerable<int>> GetNewStoryIdsAsync();
        Task<Item> GetItemAsync(int itemId);

    }

    public class HackerNewsClient : IHackerNewsClient
    {
        private readonly IConfiguration _config;
        private readonly HttpClient _client;

        public HackerNewsClient(HttpClient client, IConfiguration config)
        {
            _client = client;
            _config = config;
        }

        public async Task<IEnumerable<int>> GetNewStoryIdsAsync()
        {
            var request = new HttpRequestMessage(HttpMethod.Get, _config.GetSection("AppSettings:HackerNewsNewStories").Value + ".json");
            var result = await _client.SendAsync(request);

            if (result.IsSuccessStatusCode)
            {
                var newStories = JsonConvert.DeserializeObject<IEnumerable<int>>(
                    await result.Content.ReadAsStringAsync()
                );
                return newStories;
            }
            
            return new int[0];
            
        }

        public async Task<Item> GetItemAsync(int itemId)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, _config.GetSection("AppSettings:HackerNewsItem").Value + "/" + itemId.ToString() + ".json");
            var result = await _client.SendAsync(request);

            if (result.IsSuccessStatusCode)
            {
                var hnItem = JsonConvert.DeserializeObject<Item>(
                    await result.Content.ReadAsStringAsync()
                );

                return hnItem;
            }

            return null;
        }
    }
}