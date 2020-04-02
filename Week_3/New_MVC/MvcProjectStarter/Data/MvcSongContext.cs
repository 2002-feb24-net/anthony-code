using System;
using Microsoft.EntityFrameworkCore;
using MvcProjectStarter.Models;

namespace MvcProjectStarter.Data
{
    public class MvcSongContext : DbContext
    {
        public MvcSongContext(DbContextOptions<MvcSongContext> options) : base(options)
        {

        }

        public  DbSet<Song> Song {get; set;}
    }
}