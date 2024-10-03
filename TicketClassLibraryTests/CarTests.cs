using Microsoft.VisualStudio.TestTools.UnitTesting;
using TicketClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketClassLibraryTests
{
    /// <summary>
    /// Unit tests for the Car class.
    /// </summary>
    [TestClass()]
    public class CarTests
    {
        [TestMethod()]
        /// <summary>
        /// Tests that the Price method returns the correct fixed price.
        /// </summary>
        public void Price_ShouldReturnFixedPriceOf240()
        {
            // Arrange
            var car = new Car();

            int expectedPrice = 240;
            // Act
            var price = car.Price();

            // Assert
            Assert.AreEqual(expectedPrice, price);
        }

        [TestMethod]
        /// <summary>
        /// Tests that the VehicleType method returns "Car".
        /// </summary>
        public void VehicleType_ShouldReturnCar()
        {
            // Arrange
            var car = new Car();

            // Act
            var vehicleType = car.VehicleType();

            // Assert
            Assert.AreEqual("Car", vehicleType);
        }
    }
}