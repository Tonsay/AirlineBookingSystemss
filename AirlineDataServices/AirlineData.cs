using AirlineBookingModel;
using System.Collections.Generic;
namespace AirlineDataServices
    {
        public class AirlineData
        {
        public List<Booking> bookinguser = new List<Booking>();

            public AirlineData()
            {
                CreateBookingUser();
            }

            private void CreateBookingUser()
            {
                Booking user = new Booking { username = "Jepoy Satur", password = "none" };
                bookinguser.Add(user);
            }

            public Booking GetBooking(string username, string password)
            {
                Booking foundBooking = new Booking();
                foreach (var booking in bookinguser)
                {
                    if (username == booking.username && password == booking.password)
                    {
                        foundBooking = booking;
                    }
                }
                return foundBooking;
            }
        }
    }
