using System;

namespace Singleton
{
    public class Instance
    {
        public Instance()
        {
        }

        public void InstanceInfo()
        {
            Console.WriteLine(this.GetHashCode());
        }
    }
}