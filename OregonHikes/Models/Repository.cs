using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OregonHikes.Models
{
    public class Repository
    {
        public static List<UserReviews> reviews = new List<UserReviews>();      //creates a list for userReviews

        public static IEnumerable<UserReviews> Reviews
        {
            get
            {
                return reviews;
            }
        }
        
        public static void AddResponse(UserReviews userReviews) //method adds review to the reviews list
        {
            reviews.Add(userReviews);
        }
            
    
    }
}
