using ProxyPattern.RealSubject;
using ProxyPattern.Subject;

namespace ProxyPattern.Proxy
{
    public class MakeMyTripProxy : IAirTicket
    {
        private IAirTicket makeMyTrip = new MakeMyTrip();

        public decimal GetTicketPrice()
        {
            return makeMyTrip.GetTicketPrice();
        }
    }
}