using AbstractFactory.AbstractAuto;
using System;

namespace AbstractFactory.Autos
{
    public class MarutiBreeza : ISportsCar
    {
        public string ModelName
        {
            get;
            set;
        }

        public MarutiBreeza()
        {
            this.ModelName = "Maruti Breeza";
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