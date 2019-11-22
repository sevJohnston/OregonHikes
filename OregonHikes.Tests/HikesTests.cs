using System;
using System.Collections.Generic;
using System.Text;
using OregonHikes.Models;
using Xunit;

namespace OregonHikes.Tests
{
    public class HikesTests
    {
        [Fact]
        public void AddHikesTest()
        {
            //arrange
            var h = new Hike { TrailName = "Mt Pisgah Summit", Region = "Willamette Valley",
                Description = "Great local hike for exercise and views.", };

            //act
            h.TrailName
        }
    }
}
