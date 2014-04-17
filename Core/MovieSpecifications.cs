using System.Collections.Generic;
using System.Linq;

namespace MvcMovie.Models {
    public static class MovieSpecifications {

        public static IEnumerable<Movie> ByGenre(this IEnumerable<Movie> movies, string genre) {
            return movies.Where(m =>
                string.IsNullOrWhiteSpace(genre) ||
                m.Genre.Equals(genre));
        }

        public static IEnumerable<Movie> ByPartialTitle(this IEnumerable<Movie> movies, string search) {
            return movies.Where(m =>
                string.IsNullOrWhiteSpace(search) ||
                m.Title.ToLower().Contains(search.ToLower()));
        }
    }
}