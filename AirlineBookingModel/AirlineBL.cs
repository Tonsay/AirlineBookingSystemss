using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineBookingModel
{
    public class AirlineBL
    {
        public string name;
        List<Booking> airlines = new List<Booking>();
        public void AddBooking(Booking airline)
        {
            airlines.Add(airline);
        }

        public void SearchAirline(string name)
        {
            foreach (Booking details in airlines)
            {
                if (details.name == name)
                {
                    Console.WriteLine("DETAILS FOUND....");
                    DisplayBookingInfo(details);
                }
            }
        }
        public void DisplayBookingInfo(Booking airlines)
        {
            Console.WriteLine("AIRLINE DETAILS " + name + "...");
            Console.WriteLine("PASSENGERS NAME:" + airlines.name);
            Console.WriteLine("FLIGHT CLASS TYPE:" + airlines.classtype);
            Console.WriteLine("ORIGIN: " + airlines.origin);
            Console.WriteLine("FLIGHT DESTINATION: " + airlines.destination);
            Console.WriteLine("DATE OF FLIGHT: " + airlines.flightdate);
            Console.WriteLine("----------------------------------------------");
        }

        public void DeleteBooking(Booking airline)
        {
            airlines.Remove(airline);
        }
    }
}