using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OregonHikes.Models
{
    public class Hike
    {
        private List<Hike> hikes = new List<Hike>();
        private List<UserReview> reviews = new List<UserReview>();
        
        public string TrailName { get; set; }        
        public string Region { get; set; }       
        public string Description { get; set; }

        public List<Hike> Hikes { get { return hikes; } }
        public List<UserReview> UserReviews { get { return reviews; } }
    }
}
