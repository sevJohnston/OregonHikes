using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OregonHikes.Models
{
    public class UserReviews        //model to recieve user reviews
    {
        public string UserName { get; set; }
        public string TrailName { get; set; }
        public string Region { get; set; }
        public string Review { get; set; }
    }
}
