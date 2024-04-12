using AirlineDataServices;
namespace AirlineBusinessService
{
    public class AirlineBusiness
    {
        public bool VerifyBooking(string username, string password)
        {
            bool popo = new bool();
            AirlineData service = new AirlineData();
            var result = service.GetBooking(username, password);

            if (result.username != null && result.password != null)
            {
                popo = true;
            }
            else
            {
                popo = false;
            }
            return popo;
        }

    }
}
