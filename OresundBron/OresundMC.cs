using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketClassLibrary;

namespace OresundBron
{
    public class OresundMC : Vehicle
    {
        private const double RegularPrice = 210;
        private const double BrobizzPrice = 73;

        public override double Price()
        {
            // Apply Brobizz price if Brobizz is used, otherwise regular price
            return HasBrobizz ? BrobizzPrice : RegularPrice;
        }

        public override string VehicleType()
        {
            return "Oresund MC";
        }
    }
}
