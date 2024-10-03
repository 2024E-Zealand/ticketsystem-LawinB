using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketClassLibrary
{
    /// <summary>
    /// Represents a motorcycle (MC) with a license plate and date.
    /// </summary>
    public class MC
    {
        /// <summary>
        /// Gets or sets the license plate of the motorcycle.
        /// </summary>
        public string Licenseplate { get; set; }

        /// <summary>
        /// Gets or sets the date associated with the motorcycle (e.g., parking or ticket date).
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// Returns the price for the motorcycle, which is fixed at 125 kr.
        /// </summary>
        /// <returns>The fixed price of 125 kr.</returns>
        public double Price()
        {
            return 125;
        }

        /// <summary>
        /// Returns the type of the vehicle, which is always "MC".
        /// </summary>
        /// <returns>A string representing the vehicle type, "MC".</returns>
        public string VehicleType()
        {
            return "MC";
        }
    }
}

