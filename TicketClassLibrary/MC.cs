using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketClassLibrary
{
    /// <summary>
    /// Represents a motorcycle (MC).
    /// </summary>
    public class MC : Vehicle
    {
        /// <summary>
        /// Returns the price for the motorcycle, which is fixed at 125.
        /// </summary>
        /// <returns>The fixed price of 125.</returns>
        public override double Price()
        {
            return 125;
        }

        /// <summary>
        /// Returns the type of the vehicle, which is "MC".
        /// </summary>
        /// <returns>A string representing the vehicle type, "MC".</returns>
        public override string VehicleType()
        {
            return "MC";
        }
    }
}
