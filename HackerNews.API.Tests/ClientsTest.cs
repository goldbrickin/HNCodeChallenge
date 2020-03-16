using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using HackerNews.API.Dtos;
using HackerNews.API.Helpers;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HackerNews.API.Tests
{
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
}