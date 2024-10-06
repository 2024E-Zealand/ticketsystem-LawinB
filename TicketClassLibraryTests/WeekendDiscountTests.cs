using Microsoft.VisualStudio.TestTools.UnitTesting;
using TicketClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketClassLibrary.Tests
{
    [TestClass()]
    public class WeekendDiscountTests
    {
        [TestMethod()]
        public void Car_Price_OnWeekend_WithoutBrobizz_ShouldApplyWeekendDiscount()
        {
            // Arrange
            var car = new Car
            {
                Date = new DateTime(2024, 10, 5), // Saturday
                HasBrobizz = false
            };

            // Act
            double price = car.Price();

            // Assert
            double expectedPrice = 240 * 0.80; // 20% weekend discount
            Assert.AreEqual(expectedPrice, price, 0.01);
        }

        [TestMethod()]
        public void Car_Price_OnWeekend_WithBrobizz_ShouldApplyBothDiscounts()
        {
            // Arrange
            var car = new Car
            {
                Date = new DateTime(2024, 10, 6), // Sunday
                HasBrobizz = true
            };

            // Act
            double price = car.Price();

            // Assert
            double weekendDiscountedPrice = 240 * 0.80; // 20% weekend discount
            double expectedPrice = weekendDiscountedPrice * 0.95; // 5% Brobizz discount
            Assert.AreEqual(expectedPrice, price, 0.01);
        }

        [TestMethod()]
        public void Car_Price_NotOnWeekend_WithBrobizz_ShouldApplyBrobizzDiscountOnly()
        {
            // Arrange
            var car = new Car
            {
                Date = new DateTime(2024, 10, 4), // Friday
                HasBrobizz = true
            };

            // Act
            double price = car.Price();

            // Assert
            double expectedPrice = 240 * 0.95; // 5% Brobizz discount only
            Assert.AreEqual(expectedPrice, price, 0.01);
        }

        [TestMethod()]
        public void Car_Price_NotOnWeekend_WithoutBrobizz_ShouldReturnFullPrice()
        {
            // Arrange
            var car = new Car
            {
                Date = new DateTime(2024, 10, 4), // Friday
                HasBrobizz = false
            };

            // Act
            double price = car.Price();

            // Assert
            Assert.AreEqual(240, price, 0.01);
            
        }
    }
}