using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OregonHikes.Models
{
    public class Repository
    {
        private static List<Person> people = new List<Person>();     //creates a list for people and groups
        public static List<Person> People { get { return people; } }

        static Repository()
        {
            AddPeopleSeedData();    //adds the hard coded list of people/
        }

        public static void AddPeople(Person person)
        {
            people.Add(person);
        }

        public static void AddPeopleSeedData()
        {
            Person person = new Person()
            {
                PeopleName = "Willamette Valley Great Old Broads for Wilderness",
                Link = "https://www.greatoldbroads.org/directory-of-broadbands/oregon-willamette-valley-broadband/",
                Description = "Great Old Broads for Wilderness is a national grassroots organization, led by women, " +
                "that engages and inspires activism to preserve and protect wilderness and wild lands. " +
                "Our local chapters hike together and work with other conservation groups to " +
                "advocate for local wildlands."
            };
            people.Add(person);

            person = new Person()
            {
                PeopleName = "William Sullivan",
                Link = "http://www.oregonhiking.com/william-l-sullivan",
                Description = "William L. Sullivan is the author of 22 books and numerous articles about Oregon, " +
                "including a feature column for the Eugene Register-Guard."
            };
            people.Add(person);

            person = new Person()
            {
                PeopleName = "Mazamas",
                Link = "https://mazamas.org/",
                Description = "The Mazamas is a robust community of individuals" +
                "who love to recreate in and protect the outdoors."
            };
            people.Add(person);

            person = new Person()
            {
                PeopleName = "Obsidians",
                Link = "http://www.obsidians.org/",
                Description = "Organized in 1927 by a group of men from Eugene" +
                " who were concerned about a mountaineering accident," +
                "the Obsidians have grown to more than 400 people " +
                "actively involved in a wide variety of outdoor activities."

            };
            people.Add(person);
        }
    }
}
