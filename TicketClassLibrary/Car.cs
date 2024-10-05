 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketClassLibrary
{
        public class Car : Vehicle
        {
            private const double WeekendDiscount = 0.20; // 20% discount for weekends
            private const double BasePrice = 240.0;      // Base price for cars

            public override double Price()
            {
                double price = BasePrice;

                // Apply weekend discount if it's Saturday or Sunday
                if (Date.DayOfWeek == DayOfWeek.Saturday || Date.DayOfWeek == DayOfWeek.Sunday)
                {
                    price *= (1 - WeekendDiscount);  // Apply 20% weekend discount
                }

                // Apply Brobizz discount if applicable (after weekend discount)
                return ApplyBrobizzDiscount(price);
            }

            public override string VehicleType()
            {
                return "Car";
            }
        }
}
