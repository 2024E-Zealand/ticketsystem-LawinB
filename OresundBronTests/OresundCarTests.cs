using Microsoft.VisualStudio.TestTools.UnitTesting;
using OresundBron;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OresundBron.Tests
{
    [TestClass()]
    public class OresundCarTests
    {
        [TestMethod()]
        public void OresundCar_Price_WithoutBrobizz_ShouldReturnRegularPrice()
        {
            // Arrange
            var car = new OresundCar
            {
                HasBrobizz = false
            };

            // Act
            double price = car.Price();

            // Assert
            Assert.AreEqual(410.0, price, 0.01);
        }

        [TestMethod()]
        public void OresundCar_Price_WithBrobizz_ShouldReturnDiscountedPrice()
        {
            // Arrange
            var car = new OresundCar
            {
                HasBrobizz = true
            };

            // Act
            double price = car.Price();

            // Assert
            Assert.AreEqual(161.0, price, 0.01);
        }

        [TestMethod()]
        public void OresundCar_VehicleType_ShouldReturnOresundCar()
        {
            // Arrange
            var car = new OresundCar();

            // Act
            string vehicleType = car.VehicleType();

            // Assert
            Assert.AreEqual("Oresund car", vehicleType);
        }
    }
}



  