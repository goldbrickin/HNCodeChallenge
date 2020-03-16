using System.Collections.Generic;
using System.Threading.Tasks;
using HackerNews.API.Controllers;
using HackerNews.API.Dtos;
using HackerNews.API.Helpers;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HackerNews.API.Tests
{
    public class RepositoriesTest
    {
        [TestClass]
        public class HackerNewsTests
        {
            [TestMethod]
            public async Task GetNewStoriesTest()
            {
                var services = new ServiceCollection();
                services.AddMemoryCache();
                var serviceProvider = services.BuildServiceProvider();

                var memoryCache = serviceProvider.GetService<IMemoryCache>();
                var hackerNewsRepo = new HackerNews.API.Data.HackerNewsRepository(new TestHackerNewsClient(), memoryCache);
                
                var controller = new HackerNewsController(hackerNewsRepo);
                
                var result = await controller.GetNewStories();
                
                Assert.IsNotNull(result);
            }

            [TestMethod]
            public async Task GetNewStoriesRepoTest()
            {
                var services = new ServiceCollection();
                services.AddMemoryCache();
                var serviceProvider = services.BuildServiceProvider();

                var memoryCache = serviceProvider.GetService<IMemoryCache>();
                var hackerNewsRepo = new HackerNews.API.Data.HackerNewsRepository(new TestHackerNewsClient(), memoryCache);
                
                var result = await hackerNewsRepo.GetNewStories();

                Assert.IsNotNull(result);
            }

        }

        // [TestClass]
        // public class HackerNewsClientTest
        // {
        //     [TestMethod]
        //     public async Task GetItemAsyncTest()
        //     {
        //         var services = new ServiceCollection();
        //         //services.AddHttpClient();
        //         services.AddHttpClient<IHackerNewsClient, HackerNewsClient>(client =>
        //         {
        //             client.BaseAddress = new Uri("https://hacker-news.firebaseio.com/v0/");
        //             client.DefaultRequestHeaders.Add("Accept", "application/json");
        //         });
                
        //         services.AddTransient<IConfiguration>(sp =>
        //         {
        //             IConfigurationBuilder configurationBuilder = new ConfigurationBuilder();
        //             configurationBuilder.AddJsonFile("appsettings.json");
        //             return configurationBuilder.Build();
        //         });

        //         var serviceProvider = services.BuildServiceProvider();

        //         var httpClient = serviceProvider.GetService<HttpClient>();
        //         var config = serviceProvider.GetService<IConfiguration>();
                
        //         //httpClient.BaseAddress = new Uri("https://hacker-news.firebaseio.com/v0/");
        //         //httpClient.DefaultRequestHeaders.Add("Accept", "application/json");
                
        //         var hackerNewsClient = new HackerNews.API.Helpers.HackerNewsClient(httpClient, config);

        //         var story = await hackerNewsClient.GetItemAsync(22588426);

        //         Assert.IsNotNull(story);   
        //     }
        // }

        public class TestHackerNewsClient : IHackerNewsClient
        {
            public Task<IEnumerable<int>> GetNewStoryIdsAsync()
            {
                IEnumerable<int> listOfInts = new List<int>{1,2,3,4,5};

                return Task.FromResult(listOfInts);
            }

            public Task<Item> GetItemAsync(int itemId)
            {
                if (itemId == 1)
                {
                    return Task.FromResult(
                        new Item
                        {
                            id = 1,
                            deleted = false,
                            type = "Story",
                            by = "Bryan",
                            time = 1584140699,
                            text = "This is the text of a dummy story.",
                            dead = false,
                            parent = 0,
                            poll = 1,
                            kids = new int[0],
                            url = "https://goldbrickin.org",
                            score = 5,
                            title = "Dummy Story Title",
                            parts = new int[0],
                            descendants = 0
                        });
                }
                else
                    return Task.FromResult<Item>(null);
            }
        }
    }
}