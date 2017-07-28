using Microsoft.EntityFrameworkCore;

namespace music_store.Models
{
    public class MvcMovieContext : DbContext
    {
        public MvcMovieContext (DbContextOptions<MvcMovieContext> options)
            : base(options)
        {
        }

        public DbSet<music_store.Models.Movie> Movie { get; set; }
    }
}