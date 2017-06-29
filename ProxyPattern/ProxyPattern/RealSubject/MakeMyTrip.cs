using ProxyPattern.Subject;

namespace ProxyPattern.RealSubject
{
    public class MakeMyTrip : IAirTicket
    {
        public decimal GetTicketPrice()
        {
            return 25000;
        }
    }
}