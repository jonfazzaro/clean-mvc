using System.Collections.Generic;
using System.Linq;

namespace MvcMovie.Models {
    public static class MovieSpecifications {

        public static IQueryable<Movie> ByGenre(this IQueryable<Movie> movies, string genre) {
            return movies.Where(m =>
                (genre == null || genre.Trim() == string.Empty) ||
                m.Genre.Equals(genre));
        }

        public static IQueryable<Movie> ByPartialTitle(this IQueryable<Movie> movies, string search) {
            return movies.Where(m =>
                (search == null || search.Trim() == string.Empty) ||
                m.Title.ToLower().Contains(search.ToLower()));
        }
    }
}