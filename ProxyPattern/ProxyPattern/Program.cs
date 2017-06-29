using ProxyPattern.Proxy;
using System;

namespace ProxyPattern
{
    internal class Program
    {
        /*
         There are four common situations in which the Proxy pattern is applicable:
         1. A "virtual proxy" is a placeholder for "expensive to create" objects.
            The real object is only created when a client first requests/accesses the object.
         2. A "remote proxy" provides a local representative for an object that resides in a different address space.
         3. A "protective proxy" controls access to a sensitive master object. The "surrogate" object checks that the caller has the access permissions required prior to forwarding the request
         4. A "smart proxy" interposes additional actions when an object is accessed.
            Added functionality is required when an object is accessed.
        */

        private static void Main(string[] args)
        {
            MakeMyTripProxy proxy = new MakeMyTripProxy();
            Console.WriteLine(proxy.GetTicketPrice());
            Console.Read();
        }
    }
}