using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using RestaurantReviews.Library.Models;

namespace RestaurantReviews.Library
{
    class ResterauntContext : DbContext
    {
        public DbSet<Restaurant> Restaurants { get; set; }
        public DbSet<Review> Reviews { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Data Source=../../../resteraunt.db";
            optionsBuilder.UseSqlite(connectionString);
        }
    }
}
