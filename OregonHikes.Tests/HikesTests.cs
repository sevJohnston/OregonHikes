using System;
using System.Collections.Generic;
using System.Text;
using OregonHikes.Controllers;
using OregonHikes.Models;
using OregonHikes.Repositories;
using Xunit;

namespace OregonHikes.Tests
{
    public class HikesTests
    {
        /*
        static void AddHikeTestData()
        {
            Hike hike = new Hike()
            private static List<Hike> hikes = new List<Hike>();
            public List<Hike> Hikes { get { return hikes; } }
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
        */

        [Fact]
        public void AddHikeTest()
        {
            //arrange
            var repo = new FakeHikeRepository();
            var homeController = new HomeController(repo);
            var h = new Hike { TrailName = "Mt Pisgah Summit", Region = "Willamette Valley",
                Description = "Great local hike for exercise and views.", };

            //act
            repo.AddHike(h);

            //assert
            Assert.Equal("Mt Pisgah Summit", 
                repo.Hikes[repo.Hikes.Count - 1].TrailName);
            //this also tests the constructor- 3 hikes in test data + hike 4
            Assert.Equal(4, repo.Hikes.Count);      
        }
        
        [Fact]
        public void TestGetHikeByRegion()
        {
            //arrange
            var repo = new FakeHikeRepository();
            var homeController = new HomeController(repo);
 
            //act
            var x = repo.GetHikeByRegion("Coast");
           
            //assert
            Assert.Equal("Cook's Ridge", x.TrailName);           
        }

        [Fact]
        public void TestGetHikeByTrailName()
        {
            //arrange
            var repo = new FakeHikeRepository();
            var homeController = new HomeController(repo);
            
            //act
            var h = repo.GetHikeByTrailName("Fall Creek Falls");

            //assert
            Assert.Equal("Southern Oregon", h.Region);
        }
    }
}
