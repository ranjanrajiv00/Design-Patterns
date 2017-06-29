using AbstractFactory.AbstractAuto;
using System;

namespace AbstractFactory.Autos
{
    public class MarutiWaganor : IEconomyCar
    {
        public string ModelName
        {
            get;
            set;
        }

        public MarutiWaganor()
        {
            this.ModelName = "Maruti Waganor";
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