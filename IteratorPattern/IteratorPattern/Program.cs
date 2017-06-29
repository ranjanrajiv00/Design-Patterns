using IteratorPattern.Aggregate;
using System;

namespace IteratorPattern
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("*********** ForEach ******************");
            var employees = new string[] { "Rajiv", "Ranjan", "Ribha" };
            foreach (var employee in employees)
            {
                Console.WriteLine(employee);
            }

            // Aggregate Interface : IEnumerable
            // Iterator Interface : IEnumerator

            Console.WriteLine("*********** IEnumerable and IEnumerator ******************");

            var employeeEnumerator = employees.GetEnumerator();
            while (employeeEnumerator.MoveNext())
            {
                Console.WriteLine(employeeEnumerator.Current);
            }

            Console.WriteLine("*********** Itegator Design Pattern ******************");

            ConcreteAggregate aggregate = new ConcreteAggregate();

            aggregate[0] = new Employee() { Name = "Rajiv", EmpCode = "100" };
            aggregate[1] = new Employee() { Name = "Ranjan", EmpCode = "101" };

            var iterator = aggregate.CreateIterator();
            while (iterator.MoveNext())
            {
                var employee = ((Employee)iterator.Current);
                Console.WriteLine("{0} {1}", employee.Name, employee.EmpCode);
            }

            Console.Read();
        }
    }
}