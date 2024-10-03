namespace TicketClassLibrary
{
    /// <summary>
    /// Represents a car with a license plate and date.
    /// </summary>
    public class Car
    {
        /// <summary>
        /// Gets or sets the license plate of the car.
        /// </summary>
        public string Licenseplate { get; set; }

        /// <summary>
        /// Gets or sets the date associated with the car (e.g., parking or ticket date).
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// Returns the price for the car, which is fixed at 240.
        /// </summary>
        /// <returns>The fixed price of 240.</returns>
        public double Price()
        {
            return 240;
        }

        /// <summary>
        /// Returns the type of the vehicle, which is always "Car".
        /// </summary>
        /// <returns>A string representing the vehicle type, "Car".</returns>
        public string VehicleType()
        {
            return "Car";
        }
    }
}

