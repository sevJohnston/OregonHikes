using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace OregonHikes.Models
{
    public class Contact
    {
        //private List<Contact> messages = new List<Contact>();

        [Required(ErrorMessage = "Please enter your user name.")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Please enter your email.")]
        public string Email { get; set; }
        public DateTime WhenSent { get; set; }      //how do I make this generate automatically?
        [Required(ErrorMessage = "Please enter your message.")]
        public string MessageText { get; set; }

       // public List<Contact> Messages { get { return messages; } }
    }
}
