using System;

namespace Singleton
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            PrintHeader("Instance");
            var instance1 = new Instance();
            instance1.InstanceInfo();

            var instance2 = new Instance();
            instance2.InstanceInfo();

            PrintHeader("Singleton");
            var singleton1 = Singleton.Instance;
            singleton1.IntanceInfo();

            var singleton2 = Singleton.Instance;
            singleton2.IntanceInfo();

            PrintHeader("LazySingleton");
            var lazySingleton1 = LazySingleton.Instance;
            lazySingleton1.InstanceInfo();

            var lazySingleton2 = LazySingleton.Instance;
            lazySingleton2.InstanceInfo();

            Console.ReadKey();
        }

        private static void PrintHeader(string header)
        {
            Console.WriteLine("************************{0}****************************", header);
        }
    }
}