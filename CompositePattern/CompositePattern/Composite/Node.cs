using System;
using System.Collections.Generic;

namespace CompositePattern.Composite
{
    public class Node : IComponent
    {
        private List<IComponent> _childrens = new List<IComponent>();

        public string Name { get; set; }

        public Node(string name)
        {
            Name = name;
        }

        public void Add(IComponent component)
        {
            _childrens.Add(component);
        }

        public void Remove(IComponent component)
        {
            _childrens.Remove(component);
        }

        public void Display(int depth)
        {
            Console.WriteLine(new String('-', depth) + Name);

            // Recursively display child nodes
            foreach (IComponent component in _childrens)
            {
                component.Display(depth + 2);
            }
        }
    }
}