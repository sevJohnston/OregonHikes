using System.ComponentModel.DataAnnotations;

namespace OregonHikes.Models
{
    public class UserReview        //model to recieve user reviews
    {
        [Required(ErrorMessage = "Please enter your user name.")]
        public User UserName { get; set; }
        //[Required(ErrorMessage = "Please enter the trail name.")]
        //public string TrailName { get; set; }
        //[Required(ErrorMessage = "Please select a region.")]
        //public string Region { get; set; }
        [Required(ErrorMessage = "Please enter your review.")]
        public string Review { get; set; }

        //Do I need a UserReviewID ??? How is it generated?
    }
}
