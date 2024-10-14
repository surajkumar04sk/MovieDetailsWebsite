using Microsoft.EntityFrameworkCore;
using MovieDetailsWebsite.Data;
using MovieDetailsWebsite.Models;
using Newtonsoft.Json.Linq;
using System.Net.Http;
using System.Threading.Tasks;
namespace MovieDetailsWebsite.Services
{
    public class MovieService
    {
        private readonly MovieContext _context;
        private readonly string _apiKey;

        public MovieService(MovieContext context, IConfiguration config)
        {
            _context = context;
            _apiKey = config["TheMovieDb:ApiKey"];
        }

        public async Task<Movie> FetchMovieDetails(int movieId)
        {
            using var client = new HttpClient();
            var response = await client.GetAsync($"https://api.themoviedb.org/3/movie/{movieId}?api_key={_apiKey}");
            response.EnsureSuccessStatusCode();

            var content = await response.Content.ReadAsStringAsync();
            var movieJson = JObject.Parse(content);

            return new Movie
            {
                Title = movieJson["title"].ToString(),
                ReleaseDate = DateTime.Parse(movieJson["release_date"].ToString()),
                Description = movieJson["overview"].ToString(),
                Overview = movieJson["tagline"].ToString(),
                PosterUrl = $"https://image.tmdb.org/t/p/w500{movieJson["poster_path"]}",
                MovieId = movieId
            };
        }

        public async Task AddMovieToDatabase(int movieId)
        {
            if (_context.Movies.Any(m => m.MovieId == movieId))
                return;

            var movie = await FetchMovieDetails(movieId);
            _context.Movies.Add(movie);
            await _context.SaveChangesAsync();
        }


        public async Task<List<Movie>> GetMoviesFromDatabase()
        {
            return await _context.Movies
                                 .OrderByDescending(m => m.Id) // Order by Id, newest (largest Id) first
                                 .ToListAsync();
        }
    }
}