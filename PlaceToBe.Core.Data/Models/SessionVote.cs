using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaceToBe.Core.Data.Models
{
    public class SessionVote
    {
        public int SessionVoteId { get; set; }

        public string Occasion { get; set; }

        public DateTime DebutSession { get; set; }

        public DateTime FinSession { get; set; }

        public virtual List<Vote> Votes { get; set; }

        public virtual List<Restaurant> Restaurants { get; set; }
    }
}
