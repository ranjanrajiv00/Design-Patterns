using System.Collections.Generic;

namespace Adapter
{
    public class PatientAdapter : PatientPortal, ITarget
    {
        public List<string> GetPatiens()
        {
            List<string> patients = new List<string>();
            string[][] patientFromPortal = base.GetPatient();

            foreach (string[] patient in patientFromPortal)
            {
                patients.Add(patient[0]);
                patients.Add(",");
                patients.Add(patient[1]);
                patients.Add(",");
                patients.Add(patient[2]);
                patients.Add("\n");
            }

            return patients;
        }
    }
}