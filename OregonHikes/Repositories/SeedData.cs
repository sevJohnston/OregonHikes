using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OregonHikes.Models;


namespace OregonHikes.Repositories
{
    public class SeedData
    {
        public static void Seed(AppDbContext context)
        {
            if (!context.Hikes.Any())
            {               
                User user = new User { UserName = "Bob Johnston" };
                context.Users.Add(user);

                UserReview review = new UserReview
                {
                    Review = "Great hike, check it out!",
                    UserName = user
                };
                context.UserReviews.Add(review);
               
                Hike hike = new Hike
                {
                    TrailName = "Fall Creek Falls",
                    Region = "Southern Oregon", //if I want to sort by region I think I need to add a new list?
                    Description = "This short shady trail follows a cascading creek, squeezes through a crack in a house-sized boulder, " +
                "and takes you to a double waterfall. A popular hike for kids."
                };
                hike.UserReviews.Add(review);
                context.Hikes.Add(hike);

                context.SaveChanges(); // save all the data
            }
        }
    }
}
    

