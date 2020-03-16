namespace HackerNews.API.Dtos
{
    public class User
    {
        public string id { get; set; }
        public int delay { get; set; }
        public int created { get; set; }
        public int karma { get; set; }
        public string about { get; set; }
        public int[] submitted { get; set; }
    }
}