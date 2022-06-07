using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaceToBe.Core.Data.Models
{
    public class Restaurant
    {
        [Key]
        public int RestaurantId { get; set; }

        public string Nom { get; set; }

        public string Genre { get; set; }

        public string PrixMoyen { get; set; }

        public string Adresse { get; set; }

        public string Telephone { get; set; }

        public string ImageLink { get; set; }
    }
}
