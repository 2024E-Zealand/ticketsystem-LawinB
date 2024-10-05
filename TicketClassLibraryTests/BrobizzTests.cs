using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketClassLibrary;

namespace TicketClassLibraryTests
{
    /// <summary>
    /// Unit test for Brobiz discount.
    /// </summary>
    [TestClass()]
    public class BrobizzTests
    {
            [TestMethod]
            public void Car_Price_WithBrobizz_ShouldReturnDiscountedPrice()
            {
                // Arrange
                Vehicle car = new Car
                {
                    HasBrobizz = true
                };

                // Act
                var price = car.Price();

                // Assert
                double expectedPrice = 240 * 0.95; // 5% discount
                Assert.AreEqual(expectedPrice, price, 0.01); // delta to account for floating point precision
            }

            [TestMethod()]
            public void MC_Price_WithBrobizz_ShouldReturnDiscountedPrice()
            {
                // Arrange
                Vehicle mc = new MC
                {
                    HasBrobizz = true
                };

                // Act
                var price = mc.Price();

                // Assert
                double expectedPrice = 125 * 0.95; // 5% discount
                Assert.AreEqual(expectedPrice, price, 0.01); // delta to account for floating point precision
            }

            [TestMethod()]
            public void Car_Price_WithoutBrobizz_ShouldReturnFullPrice()
            {
                // Arrange
                Vehicle car = new Car
                {
                    HasBrobizz = false
                };

                // Act
                var price = car.Price();

                // Assert
                Assert.AreEqual(240, price, 0.01);
            }

            [TestMethod()]
            public void MC_Price_WithoutBrobizz_ShouldReturnFullPrice()
            {
                // Arrange
                Vehicle mc = new MC
                {
                    HasBrobizz = false
                };

                // Act
                var price = mc.Price();

                // Assert
                Assert.AreEqual(125, price, 0.01);
            }
    }
}
