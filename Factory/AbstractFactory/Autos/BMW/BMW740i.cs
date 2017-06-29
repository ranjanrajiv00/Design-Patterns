using AbstractFactory.AbstractAuto;
using System;

namespace AbstractFactory.Autos
{
    public class BMW740i : ILuxuryCar
    {
        public string ModelName
        {
            get;
            set;
        }

        public BMW740i()
        {
            this.ModelName = "BMW740i";
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