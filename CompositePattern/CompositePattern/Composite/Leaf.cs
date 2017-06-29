using System;
using System.Collections.Generic;

namespace CompositePattern.Composite
{
    public class Leaf : IComponent
    {
        private List<IComponent> _childrens = new List<IComponent>();

        public string Name { get; set; }

        public Leaf(string name)
        {
            Name = name;
        }

        public void Add(IComponent component)
        {
            Console.WriteLine("Cannot add to a leaf");
        }

        public void Remove(IComponent component)
        {
            Console.WriteLine("Cannot remove from a leaf");
        }

        public void Display(int depth)
        {
            Console.WriteLine(new String('-', depth) + Name);
        }
    }
}