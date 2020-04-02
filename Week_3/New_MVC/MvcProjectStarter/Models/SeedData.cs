using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MvcProjectStarter.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace MvcProjectStarter.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcSongContext(serviceProvider.GetRequiredService<DbContextOptions<MvcSongContext>>()))
            {
                if (context.Song.Any())
                {
                    return;
                }
                context.Song.AddRange(
                    new Song
                    {
                        title = "Dont Stop Believing",
                        genre = "Classic Rock",
                        artist = "Journey",
                        albumName = "Escape",
                        releaseDate = DateTime.Parse("1981-3-13"),
                    },
                    new Song
                    {
                        title = "Thriller",
                        genre = "Classic Rock",
                        artist = "Michael Jackson",
                        albumName = "Thriller",
                        releaseDate = DateTime.Parse("1981-5-15"),
                    },
                    new Song
                    {
                        title = "Eye of the  Tiger",
                        genre = "Classic Rock",
                        artist = "Survivor",
                        albumName = "Platinum",
                        releaseDate = DateTime.Parse("1981-6-7"),
                    }
                );
                context.SaveChanges();
            }
        }
    }
}