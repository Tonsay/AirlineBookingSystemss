using AirlineBusinessService;
using AirlineBookingModel;
namespace AirlineBookingSystemss
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Choose an Action:");
            Console.WriteLine("1. Log in ");
            Console.WriteLine("2. Get User Details");
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("Enter the number of your choice: ");

         string input = Console.ReadLine();

            switch (input)
            {
                case "1":

                    Console.WriteLine("Enter Name: ");
                    string username = Console.ReadLine();
                    Console.WriteLine("Enter Password: ");
                    string password = Console.ReadLine();

                    AirlineBusiness service = new AirlineBusiness();
                    bool result = service.VerifyBooking(username, password);

                    if (result)
                    {
                        Console.WriteLine("FOUND USER");
                    }
                    else
                    {
                        Console.WriteLine("USER NOT FOUND");
                    }

                    break;

                    
                case "2":

                    Console.WriteLine("WELCOME TO TONSAY AIRLINES!");
                    Console.WriteLine("This are the booking details...");

                    List<Booking> bookings = new List<Booking>();
                    AirlineBL myAirlineDetails = new AirlineBL();

                    Booking airline1 = new Booking();
                    airline1.name = "Jepoy Satur";
                    airline1.classtype = "First Class";
                    airline1.origin = "THAILAND";
                    airline1.destination = "PHILIPPINES";
                    airline1.flightdate = new DateTime(2025, 3, 6);

                    Booking airline2 = new Booking();
                    {
                        airline2.name = "Jihoon Lee";
                        airline2.classtype = "Economy Class";
                        airline2.origin = "SOUTH KOREA";
                        airline2.destination = "JAPAN";
                        airline2.flightdate = new DateTime(2025, 11, 22);
                    }

                    Booking airline3 = new Booking();
                    {
                        airline3.name = "Mingyu Kim";
                        airline3.classtype = "Business Class";
                        airline3.origin = "SOUTH KOREA";
                        airline3.destination = "THAILAND";
                        airline3.flightdate = new DateTime(2025, 4, 6);
                    }

                    Booking airline4 = new Booking();
                    {
                        airline4.name = "John Stamos";
                        airline4.classtype = "First Class";
                        airline4.origin = "U.S.A";
                        airline4.destination = "PHILIPPINES";
                        airline4.flightdate = new DateTime(2025, 8, 19);
                    }

                    myAirlineDetails.AddBooking(airline1);
                    myAirlineDetails.AddBooking(airline2);

                    myAirlineDetails.SearchAirline("Jepoy");
                    myAirlineDetails.DisplayBookingInfo(airline1);
                    myAirlineDetails.DisplayBookingInfo(airline2);
                    myAirlineDetails.DisplayBookingInfo(airline3);
                    myAirlineDetails.DisplayBookingInfo(airline4);

                    break;

                default:
                    Console.WriteLine("Invalid Choice");

                    break;

            }
        }
    }
}
