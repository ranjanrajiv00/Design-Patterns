using System;

namespace Problem.Autos
{
    public class Maruti : IAuto
    {
        public string ModelName
        {
            get;
            set;
        }

        public Maruti()
        {
            this.ModelName = "Maruti";
        }

        public void Start()
        {
            Console.WriteLine("{0} is started", this.ModelName);
        }

        public void Stop()
        {
            Console.WriteLine("{0} is stopped", this.ModelName);
        }
    }
}