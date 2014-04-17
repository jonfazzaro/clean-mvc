using System.Data.Entity;

namespace MvcMovie.Models {
    public class MovieDBContext : DbContext {
        public DbSet<Movie> Movies { get; set; }
    }
}
