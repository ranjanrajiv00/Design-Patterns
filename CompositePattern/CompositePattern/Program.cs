using CompositePattern.Composite;
using System;

namespace CompositePattern
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // create a tree structure
            IComponent root = new Node("CTO");
            var aviragJain = new Node("Avirag Jain");
            root.Add(aviragJain);

            IComponent sanjeevDhavan = new Node("Sanjeev Dhavan");
            IComponent manishSethi = new Leaf("Manish Sethi");
            aviragJain.Add(sanjeevDhavan);
            aviragJain.Add(manishSethi);

            IComponent aChoudhary = new Node("Arun Chaudhary");
            IComponent nVerma = new Leaf("Narendra Verma");
            sanjeevDhavan.Add(aChoudhary);
            sanjeevDhavan.Add(nVerma);

            IComponent rRanjan = new Node("Rajiv");
            IComponent atul = new Node("Atul");
            IComponent gurpreet = new Leaf("Gurpreet");

            aChoudhary.Add(rRanjan);
            aChoudhary.Add(atul);
            aChoudhary.Add(gurpreet);

            IComponent nikhil = new Leaf("Nikhil");
            IComponent kamal = new Leaf("Kamal");
            rRanjan.Add(nikhil);
            rRanjan.Add(kamal);

            IComponent gGupta = new Leaf("Gaurav");
            IComponent pGupta = new Leaf("Prerna");
            atul.Add(gGupta);
            atul.Add(pGupta);

            root.Display(1);

            Console.Read();
        }
    }
}