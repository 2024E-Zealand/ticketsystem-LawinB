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
    /// Unit tests for the MC class.
    /// </summary>
    [TestClass()]
    public class MCTests
    {
        [TestMethod()]
        /// <summary>
        /// Tests that the Price method returns the correct fixed price for MC.
        /// </summary>
        public void Price_ShouldReturnFixedPriceOf125()
        {
            // Arrange
            var mc = new MC();

            int expectedPrice = 125;
            // Act
            var price = mc.Price();

            // Assert
            Assert.AreEqual(expectedPrice, price);
        }

        [TestMethod()]
        /// <summary>
        /// Tests that the VehicleType method returns "MC".
        /// </summary>
        public void VehicleType_ShouldReturnMC()
        {
            // Arrange
            var mc = new MC();

            // Act
            var vehicleType = mc.VehicleType();

            // Assert
            Assert.AreEqual("MC", vehicleType);
        }
    }
}