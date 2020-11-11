﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RestaurantRater.Models
{
    public class Restaurant
    {
        public int ResaurantID { get; set; }
            public string Name { get; set; }
        public string Address { get; set; }
        public int Rating { get; set; }

    }
    public class ResaurantDbContext : DbContext
    {
        public DbSet<Restaurant> Restaurants { get; set; }

    }
}