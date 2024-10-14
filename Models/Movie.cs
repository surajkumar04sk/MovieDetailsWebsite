﻿using System;

namespace MovieDetailsWebsite.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Description { get; set; }
        public string Overview { get; set; }
        public string PosterUrl { get; set; }
        public int MovieId { get; set; } // TheMovieDB's Movie ID
    }
}
