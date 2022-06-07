using Microsoft.AspNetCore.Mvc;
using PlaceToBe.Core.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlaceToBe.Controllers
{
    public class RestaurantController : Controller
    {

        // recupere entities pour le controleur en entier

        #region champs privés
        public readonly AppDbContext _dbcontext = null;
        #endregion
      

        #region Constructeurs
        public RestaurantController(AppDbContext dbcontext)
        {
            this._dbcontext = dbcontext;
        }
        #endregion


        public IActionResult Index()
        {
            //on recupere notre liste

            var query = from item in this._dbcontext.Restaurants
                        select item;

            return View(query.ToList());
        }

        // methode GET de la creation
        public IActionResult AjouterRestaurant()
        {

            return View();
        }

        // methode POST de la creation
        [HttpPost]
        public ActionResult AjouterRestaurant(Restaurant restaurant)
        {
            this._dbcontext.Restaurants.Add(restaurant);
            this._dbcontext.SaveChanges();
            return View();
        }



    }
}
