using AbstractFactory.AbstractAuto;
using System;

namespace AbstractFactory.Autos
{
    public class MarutiBaleno : ILuxuryCar
    {
        public string ModelName
        {
            get;
            set;
        }

        public MarutiBaleno()
        {
            this.ModelName = "Maruti Baleno";
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