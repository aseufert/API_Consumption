namespace API_Consumption.Models
{
    public class OuterJSON
    {
        public Feed feed { get; set; }
    }

    public class Feed
    {
        public Author author { get; set; }
        public string copyright { get; set; }
        public string country { get; set; }
        public string icon { get; set; }
        public string id { get; set; }
        public string title { get; set; }
        public string updated { get; set; }
        public Results[] results { get; set; }
    }

    public class Results
    {
        public string artistId { get; set; }
        public string artistName { get; set; }
        public string artistUrl { get; set; }
        public string artworkUrl100 { get; set; }
        public string copyright { get; set; }
        public Genres[] genres { get; set; }
        public string id { get; set; }
        public string kind { get; set; }
        public string name { get; set; }
        public string releaseDate { get; set; }
        public string url { get; set; }
    }

    public class Genres
    {
        public string genreId { get; set; }
        public string name { get; set; }
        public string url { get; set; }
    }

    public class Author
    {
        public string name { get; set; }
        public string uri { get; set; }
    }
}