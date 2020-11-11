using RestaurantRater.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RestaurantRater.Controllers
{
    public class ResaurantController : Controller
    {
        // GET: Resaurant
        private RestaurantDbContext _db = new RestaurantDbContext();
        public ActionResult Index()
        {
            return View(_db.Restaurants.ToList());
        }
    }
}