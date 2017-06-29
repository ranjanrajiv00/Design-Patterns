using System;

namespace Adapter
{
    /// <summary>
    /// DataAdapters, behind the scenes it create Command object, Connection object and execute it for us.
    /// DataAdapter uses Adapter Pattern because it is adapter between Dataset and Command object, Connection object
    /// </summary>
    internal class Program
    {
        private static void Main(string[] args)
        {
            ITarget patientSource = new PatientAdapter();
            ThirdPartyBillingSystems client = new ThirdPartyBillingSystems(patientSource);
            client.DisplayPatients();
            
            Console.Read();
        }
    }
}