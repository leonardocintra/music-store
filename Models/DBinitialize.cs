using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace music_store.Models
{
    public static class DBinitialize
    {
        public static void EnsureCreated(IServiceProvider serviceProvider)
        {
            var context = new MvcMovieContext(
                serviceProvider.GetRequiredService<DbContextOptions<MvcMovieContext>>());
            context.Database.EnsureCreated();
        }
    }
}