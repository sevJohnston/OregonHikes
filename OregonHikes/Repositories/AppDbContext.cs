using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OregonHikes.Models;
using Microsoft.EntityFrameworkCore;

namespace OregonHikes.Repositories
{
    //inherits from DbContext
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        //create DbSets for each model
        public DbSet<Hike> Hikes { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserReview> UserReviews { get; set; }
        public DbSet<Person> People { get; set; }
    }
}
