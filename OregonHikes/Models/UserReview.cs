using System.ComponentModel.DataAnnotations;

namespace OregonHikes.Models
{
    public class UserReview        //model to recieve user reviews
    {
        public int UserReviewID { get; set; }
        [Required(ErrorMessage = "Please enter your user name.")]
        public User UserName { get; set; }     
        [Required(ErrorMessage = "Please enter your review.")]
        public string Review { get; set; }
        
    }
}
