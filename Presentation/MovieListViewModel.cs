using MvcMovie.Models;
using System.Collections.Generic;
using System.Linq;

namespace MvcMovie.Presentation {

    public class MovieListViewModel {

        private readonly IEnumerable<Movie> _movies;

        public MovieListViewModel(IEnumerable<Movie> movies) {
            _movies = movies;
            Title = "Movies";
            Sample = new Movie();
        }

        public string Title { get; set; }
        public string Genre { get; set; }
        public string Filter { get; set; }
        public Movie Sample { get; set; }

        public IEnumerable<string> Genres { 
            get {
                return _movies
                    .Select(m => m.Genre)
                    .Distinct();
            }
        }

        public IEnumerable<Movie> Movies {
            get { 
                return _movies
                    .ByGenre(Genre)
                    .ByPartialTitle(Filter); 
            }
        }
    }
}
