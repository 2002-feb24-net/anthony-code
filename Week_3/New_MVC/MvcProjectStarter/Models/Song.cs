using System;

namespace MvcProjectStarter.Models
{
    public class Song
    {
        public int ID { get; set; }
        public string title { get; set; }
        public string genre { get; set; }
        public string artist { get; set; }
        public string albumName { get; set; }
        public DateTime releaseDate { get; set; }
    }
}