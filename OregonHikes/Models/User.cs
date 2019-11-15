using System.Collections.Generic;

namespace OregonHikes.Models
{
    public class User
    {
        private List<UserReview> reviews = new List<UserReview>();
        private List<Contact> messages = new List<Contact>();

        //public int UserID { get; set; }     //How is the UserID generated? Probably need a User sign in page and user list?
        public string UserName { get; set; }
        public string Email { get; set; }
        public List<UserReview> Reviews { get { return reviews; } }
        public List<Contact> Comments { get { return messages; } }

    }
}
