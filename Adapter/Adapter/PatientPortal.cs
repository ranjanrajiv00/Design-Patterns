namespace Adapter
{
    /// <summary>
    /// Adaptee Class
    /// </summary>
    public class PatientPortal
    {
        public string[][] GetPatient()
        {
            string[][] patients = new string[2][];
            patients[0] = new string[] { "100", "Rajiv Ranjan", "9990656391" };
            patients[1] = new string[] { "101", "Ranjan Rajiv", "9990656398" };
            return patients;
        }
    }
}