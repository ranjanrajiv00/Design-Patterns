using AbstractFactory.AbstractAuto;
using System;

namespace AbstractFactory.Autos
{
    public class BMWM3 : ISportsCar
    {
        public string ModelName
        {
            get;
            set;
        }

        public BMWM3()
        {
            this.ModelName = "BMWM3";
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