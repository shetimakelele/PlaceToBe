using Microsoft.AspNetCore.Mvc;
using PlaceToBe.Core.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlaceToBe.Controllers
{
    public class SessionVoteController : Controller
    {
        #region champs privés
        public readonly AppDbContext _dbcontext = null;
        #endregion
        public List<Restaurant> ListDesRestaurants { get; private set; }
        // methode GET de la creation
        public IActionResult CreerSessionVote()
        {
            this.ViewBag.ListDesRestaurants = this._dbcontext.Restaurants.ToList();
            return View();
        }

        // methode POST de la creation
        [HttpPost]
        public ActionResult CreerSessionVote(SessionVote sessionVote)
        {
            this.ViewBag.ListDesRestaurants = this._dbcontext.Restaurants.ToList();
            this._dbcontext.SessionVotes.Add(sessionVote);
            this._dbcontext.SaveChanges();
            return View();
        }

    }
}
