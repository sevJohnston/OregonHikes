using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OregonHikes.Models
{
    public class Person
    {
        private static List<Person> people = new List<Person>();
        public int PersonID { get; set; }
        public string PeopleName { get; set; }
        public string Link { get; set; }               
        public string Description { get; set; }

        public List<Person> People { get { return people; } }       
    }

}
