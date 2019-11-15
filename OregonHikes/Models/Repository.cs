using System.Collections.Generic;

namespace OregonHikes.Models
{
    public class Repository
    {
        private static List<Hike> hikes = new List<Hike>();    //creates a list for hikes
        public static List<Hike> Hikes { get { return hikes; } } //not sure whether I still need this?
        private static List<Person> people = new List<Person>();     //creates a list for people and groups
        public static List<Person> People { get { return people; } }  //not sure whether I still need this?

        private static List<UserReview> reviews = new List<UserReview>();      //creates a list for userReviews
        private static List<Contact> messages = new List<Contact>();     //creates a list for user comments
        public List<UserReview> Reviews { get { return reviews; } }
        public List<Contact> Messages { get { return messages; } }
        
        public static IEnumerable<Hike> Hike     
        {
            get
            {
                return hikes;
            }
        }
       

        static Repository()
        {
            AddHikeTestData();      //adds the hard coded list of hikes
            AddPeopleTestData();    //adds the hard coded list of people/groups
        }
        

        public static void AddHike(Hike hike)
        {
            hikes.Add(hike);
        }

        
        public static Hike GetHikeByRegion(string region)
        {
            Hike hike = hikes.Find(h => h.Region == region);
            return hike;
        }

        public static Hike GetHikeByTrailName(string trailName)
        {
            Hike hike = hikes.Find(h => h.TrailName == trailName);
            return hike;
        }
        

        static void AddHikeTestData()
        {
            Hike hike = new Hike()
            {
                TrailName = "Mary's Peak",
                Region = "Willamette Valley", //if I want to sort by region I think I need to add a new list?
                Description = "A wonderful example of a temperate rain forest " +
                "with views to the ocean from the top!"
            };
            UserReview review = new UserReview();
            hikes.Add(hike);
            hike.UserReviews.Add(review);
            

            hike = new Hike()
            {
                TrailName = "Cook's Ridge",
                Region = "Coast", //if I want to sort by region I think I need to add a new list?
                Description = "A mix of old growth and second growth in the Coast Range " +
                "near Cape Perpetua and Cumming's Creek."
            };
            hikes.Add(hike);
            hike.UserReviews.Add(review);

            hike = new Hike()
            {
                TrailName = "Fall Creek Falls",
                Region = "Southern Oregon", //if I want to sort by region I think I need to add a new list?
                Description = "This short shady trail follows a cascading creek, squeezes through a crack in a house-sized boulder, " +
                "and takes you to a double waterfall. A popular hike for kids."
            };
            hikes.Add(hike);
            hike.UserReviews.Add(review);
         
        }
        /*
        public static IEnumerable<Person> People
        {
            get
            {
                return people;
            }
        }
        */

        public static void AddPeople(Person person)
        {
            people.Add(person);
        }

        public static void AddPeopleTestData()
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

        public static IEnumerable<UserReview> UserReviews
        {
            get
            {
                return reviews;
            }
        }
        
        public static void AddResponse(UserReview userReviews) //method adds review to the reviews list
        {
            reviews.Add(userReviews);
            
        }
        /*
        public static IEnumerable<Contact> Contact
        {
            get
            {
                return messages;
            }
        }
        */
        //And I cannot make this work!
        public static void AddContactMessage(Contact message) //method adds messages to the messages list
        {
            messages.Add(message);
        }
        
        
    }
}
