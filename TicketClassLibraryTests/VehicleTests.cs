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
    /// Unit tests for the Car & MC class.
    /// </summary>
    [TestClass()]
    public class VehicleTests
    {

        [TestMethod()]
        /// <summary>
        /// Tests that the Price method returns the correct fixed price.
        /// </summary>
        /// 
        public void Car_Price_ShouldReturnFixedPriceOf240()
        {
            // Arrange
            var car = new Car();

            int expectedPrice = 240;
            // Act
            var price = car.Price();

            // Assert
            Assert.AreEqual(expectedPrice, price);
        }

        [TestMethod()]
        /// <summary>
        /// Tests that the VehicleType method returns "Car".
        /// </summary>
        public void Car_VehicleType_ShouldReturnCar()
        {
            // Arrange
            var car = new Car();

            // Act
            var vehicleType = car.VehicleType();

            // Assert
            Assert.AreEqual("Car", vehicleType);
        }

        [TestMethod()]
        /// <summary>
        /// Tests that an ArgumentException is thrown if the license plate exceeds 7 characters.
        /// </summary>
        public void Car_Licenseplate_ThrowsArgumentException_WhenMoreThan7Characters()
        {
            // Arrange
            Vehicle car = new Car();

            //Act
            var ex = Assert.ThrowsException<ArgumentException>(() => car.Licenseplate = "ABCDEFGH");
            ArgumentException argumentException = Assert.ThrowsException<ArgumentException>(() => car.Licenseplate = "ABCDEFGH");

        }

        [TestMethod()]
        /// <summary>
        /// Tests that the Price method returns the correct fixed price.
        /// </summary>
        public void MC_Price_ShouldReturnFixedPriceOf125()
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
        public void MC_VehicleType_ShouldReturnMC()
        {
            // Arrange
            var mc = new MC();

            // Act
            var vehicleType = mc.VehicleType();

            // Assert
            Assert.AreEqual("MC", vehicleType);
        }

        [TestMethod()]
        /// <summary>
        /// Tests that an ArgumentException is thrown if the license plate exceeds 7 characters.
        /// </summary>
        public void MC_Licenseplate_ThrowsArgumentException_WhenMoreThan7Characters()
        {
            // Arrange
            Vehicle mc = new MC();

            //Act
            var ex = Assert.ThrowsException<ArgumentException>(() => mc.Licenseplate = "ABCDEFGH");
            ArgumentException argumentException = Assert.ThrowsException<ArgumentException>(() => mc.Licenseplate = "ABCDEFGH");

        }
    }

}
