using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketClassLibrary
{
    /// <summary>
    /// Represents a base class for different types of vehicles.
    /// </summary>
    public abstract class Vehicle
    {
        /// <summary>
        /// Gets or sets the license plate of the vehicle.
        /// </summary>
        public string Licenseplate { get; set; }

        /// <summary>
        /// Gets or sets the date associated with the vehicle (e.g., parking or ticket date).
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// Returns the price of the vehicle. Must be implemented by derived classes.
        /// </summary>
        /// <returns>The price of the vehicle.</returns>
        public abstract double Price();

        /// <summary>
        /// Returns the type of the vehicle. Must be implemented by derived classes.
        /// </summary>
        /// <returns>A string representing the vehicle type.</returns>
        public abstract string VehicleType();
    }
}
