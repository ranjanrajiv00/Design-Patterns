using System;

namespace SimpleFactory.Autos
{
    public class BMW : IAuto
    {
        public string ModelName
        {
            get;
            set;
        }

        public BMW()
        {
            this.ModelName = "BMW";
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