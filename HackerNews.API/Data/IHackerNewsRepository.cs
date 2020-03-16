using System.Collections.Generic;
using System.Threading.Tasks;
using HackerNews.API.Dtos;

namespace HackerNews.API.Data
{
    public interface IHackerNewsRepository
    {
        Task<IEnumerable<Item>> GetNewStories();
    }
}