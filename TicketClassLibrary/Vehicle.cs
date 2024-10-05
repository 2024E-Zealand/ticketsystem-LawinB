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
        private string _licenseplate;
        
        private const double BrobizzDiscount = 0.05; // 5% discount

        /// <summary>
        /// Gets or sets the license plate of the vehicle. Throws an exception if the license plate exceeds 7 characters.
        /// </summary>
        public string Licenseplate
        {
            get => _licenseplate;
            set
            {
                if (value.Length > 7)
                {
                    throw new ArgumentException("Nummerplade må ikke overskride 7 tegn.");
                }
                _licenseplate = value;
            }
        }

        /// <summary>
        /// Gets or sets the date associated with the vehicle (e.g., parking or ticket date).
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether Brobizz is used.
        /// </summary>
        public bool HasBrobizz { get; set; } = false;

        /// <summary>
        /// Returns the price of the vehicle, applying a Brobizz discount if applicable. Must be implemented by derived classes.
        /// </summary>
        /// <returns>The price of the vehicle with an optional Brobizz discount.</returns>
        public double ApplyBrobizzDiscount(double price)
        {
            return HasBrobizz ? price * (1 - BrobizzDiscount) : price;
        }

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
