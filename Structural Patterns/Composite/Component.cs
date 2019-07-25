using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Samples.StructuralPatterns.Composite
{
    public class Component<T> : IComponent<T>
    {
        public Component(T name) {
            Name = name;
        }

        public void Add(IComponent<T> component)
        {
            Console.WriteLine("Cannot add to an item");            
        }

        public IComponent<T> Remove(T component)
        {
            Console.WriteLine("Cannot remove item directly");
            return this;
        }

        public string Display(int Depth)
        {
            return new String('-', Depth) + Name + "\n";
        }

        public IComponent<T> Find(T component)
        {
            if (component.Equals(Name)) {
                return this;
            }
            return null;
        }

        public T Name {get;set;}
    }
}
