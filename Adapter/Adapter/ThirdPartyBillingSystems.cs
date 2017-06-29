using System;
using System.Collections.Generic;

namespace Adapter
{
    /// <summary>
    /// Client
    /// </summary>
    public class ThirdPartyBillingSystems
    {
        private ITarget patientSource;

        public ThirdPartyBillingSystems(ITarget patientSource)
        {
            this.patientSource = patientSource;
        }

        public void DisplayPatients()
        {
            List<string> patients = patientSource.GetPatiens();
            Console.WriteLine("######### Patient List ##########");
            foreach (var patient in patients)
            {
                Console.Write(patient);
            }
        }
    }
}