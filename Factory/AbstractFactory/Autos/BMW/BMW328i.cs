using AbstractFactory.AbstractAuto;
using System;

namespace AbstractFactory.Autos
{
    public class BMW328i : IEconomyCar
    {
        public string ModelName
        {
            get;
            set;
        }

        public BMW328i()
        {
            this.ModelName = "BMW328i";
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