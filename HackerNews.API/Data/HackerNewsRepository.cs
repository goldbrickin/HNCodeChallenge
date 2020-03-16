using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HackerNews.API.Dtos;
using HackerNews.API.Helpers;
using Microsoft.Extensions.Caching.Memory;
using Newtonsoft.Json;

namespace HackerNews.API.Data
{
    public class HackerNewsRepository : IHackerNewsRepository
    {
        private IHackerNewsClient _client;
        private readonly IMemoryCache _cache;
        
        public HackerNewsRepository(IHackerNewsClient client, IMemoryCache cache)
        {
            _client = client;
            _cache = cache;
        }

        public async Task<IEnumerable<Item>> GetNewStories()
        {
            
            if (!_cache.TryGetValue("ListOfStories", out List<Item> newStories))
            {
                List<Task<Item>> storyTasks = new List<Task<Item>>();

                var newStoryIds = await _client.GetNewStoryIdsAsync();
                newStories = new List<Item>();
                
                foreach(int storyId in newStoryIds.Take(40))
                    storyTasks.Add(_client.GetItemAsync(storyId));

                Task.WaitAll(storyTasks.ToArray());

                for (int i = 0; i < storyTasks.Count; i++)
                    newStories.Add(storyTasks[i].Result);
                
                _cache.Set("ListOfStories", newStories, TimeSpan.FromSeconds(60));
            }
            else
                Console.WriteLine("Cache Hit");
            
            return newStories;
        }
    }
}