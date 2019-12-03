using System.Linq;
using System.Collections.Generic;
using OregonHikes.Models;
using Microsoft.EntityFrameworkCore;

namespace OregonHikes.Repositories
{
    public class HikeRepository : IHikeRepository
    {
        private AppDbContext context;

        private static List<Hike> hikes = new List<Hike>();    //creates a list for hikes
        //public List<Hike> Hikes { get { return hikes; } } //not sure whether I still need this?
        public List<Hike> Hikes { get { return context.Hikes.Include(h => h.UserReviews).ToList(); } }
        //public List<Hike> Hikes { get { return context.Hikes.Include("UserReviews").ToList(); } }

        //constructor
        public HikeRepository(AppDbContext appDbContext)
        {
            context = appDbContext;
        }
        /* Calling Seed (method in SeedData.cs) instead in StartUp.cs
        public  HikeRepository()
        {
            if (hikes.Count == 0)
            {
                AddHikeSeedData();
            }          
        }
        */
        //adding the hike to dB
        public void AddHike(Hike hike)
        {
            context.Hikes.Add(hike);
            context.SaveChanges();
        }
        /*
        public void AddHike(Hike hike)
        {
            hikes.Add(hike);
        }
        */

        public Hike GetHikeByRegion(string region)
        {
            Hike hike;
            hike = context.Hikes.First(h => h.Region == region);
            return hike;
        }

        public Hike GetHikeByTrailName(string trailName)
        {
            Hike hike;  
            hike = context.Hikes.First(h => h.TrailName == trailName);
            return hike;
        }

        public void AddReview(Hike hike, UserReview review)
        {
            hike.UserReviews.Add(review);
            context.Hikes.Update(hike);
            context.SaveChanges();
        }
        /* taking this out and using SeedData.cs in Repositories-- call to Seed in StartUp.cs
        static void AddHikeSeedData()
        {
            Hike hike = new Hike()
            {
                TrailName = "Mary's Peak",
                Region = "Willamette Valley", //if I want to sort by region I think I need to add a new list?
                Description = "A wonderful example of a temperate rain forest " +
                "with views to the ocean from the top!"
            };
            //UserReview review = new UserReview();
            hikes.Add(hike);
            //hike.UserReviews.Add(review);
            hike = new Hike()
            {
                TrailName = "Cook's Ridge",
                Region = "Coast", //if I want to sort by region I think I need to add a new list?
                Description = "A mix of old growth and second growth in the Coast Range " +
                "near Cape Perpetua and Cumming's Creek."
            };
            hikes.Add(hike);
            //hike.UserReviews.Add(review);

            hike = new Hike()
            {
                TrailName = "Fall Creek Falls",
                Region = "Southern Oregon", //if I want to sort by region I think I need to add a new list?
                Description = "This short shady trail follows a cascading creek, squeezes through a crack in a house-sized boulder, " +
                "and takes you to a double waterfall. A popular hike for kids."
            };
            hikes.Add(hike);
            //hike.UserReviews.Add(review);
        }
        */
    }
}
