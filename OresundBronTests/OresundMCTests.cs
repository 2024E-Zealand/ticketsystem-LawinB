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
    public class OresundMCTests
    {
        [TestMethod()]
        public void OresundMC_Price_WithoutBrobizz_ShouldReturnRegularPrice()
        {
            // Arrange
            var mc = new OresundMC
            {
                HasBrobizz = false
            };

            // Act
            double price = mc.Price();

            // Assert
            Assert.AreEqual(210.0, price, 0.01);
        }

        [TestMethod()]
        public void OresundMC_Price_WithBrobizz_ShouldReturnDiscountedPrice()
        {
            // Arrange
            var mc = new OresundMC
            {
                HasBrobizz = true
            };

            // Act
            double price = mc.Price();

            // Assert
            Assert.AreEqual(73.0, price, 0.01);
        }

        [TestMethod()]
        public void OresundMC_VehicleType_ShouldReturnOresundMC()
        {
            // Arrange
            var mc = new OresundMC();

            // Act
            string vehicleType = mc.VehicleType();

            // Assert
            Assert.AreEqual("Oresund MC", vehicleType);
        }
    }
}
}