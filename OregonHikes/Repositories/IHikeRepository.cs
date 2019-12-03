﻿using System.Collections.Generic;
using System.Linq;
using OregonHikes.Models;

namespace OregonHikes.Repositories
{
    public interface IHikeRepository
    {
        List<Hike> Hikes { get; }
        void AddHike(Hike hike);
        void AddReview(Hike hike, UserReview review);
        Hike GetHikeByTrailName(string trailName);
        Hike GetHikeByRegion(string region);
    }
}
