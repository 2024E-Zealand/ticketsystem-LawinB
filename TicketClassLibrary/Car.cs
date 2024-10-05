using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketClassLibrary
{
    /// <summary>
    /// Represents a car.
    /// </summary>
    public class Car : Vehicle
    {
        /// <summary>
        /// Returns the price for the car, which is fixed at 240.
        /// </summary>
        /// <returns>The fixed price of 240.</returns>
        public override double Price()
        {
            return 240;
        }

        /// <summary>
        /// Returns the type of the vehicle, which is "Car".
        /// </summary>
        /// <returns>A string representing the vehicle type, "Car".</returns>
        public override string VehicleType()
        {
            return "Car";
        }
    }
}
