using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

namespace dgTvSvc.Models
{
    public class Episode
    {
    
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DateRecorded { get; set; }
        public DateTime? DateReleased { get; set; }
        public string Location { get; set; }
        public string VideoUrl { get; set; }
        public string VideoPlayer { get; set; }
        public string LowResVideo { get; set; }
        public string HighResVideo { get; set; }
        public string[] Guests { get; set; }
        public int EpisodeNumber { get; set; }
        public Link[] Links { get; set; }
    }
}