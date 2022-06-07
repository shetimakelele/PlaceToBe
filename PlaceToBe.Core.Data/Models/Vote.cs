
using PlaceToBe.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaceToBe.Core.Data.Models
{
    public class Vote
    {
        [Key]
        public int Id { get; set; }
        public virtual Restaurant Restaurant { get; set; }
        public virtual Utilisateur Utilisateur { get; set; }
    }
}
