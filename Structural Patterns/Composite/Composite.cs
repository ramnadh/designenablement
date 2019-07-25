using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Samples.StructuralPatterns.Composite
{
    public class Composite<T> : IComponent<T>
    {
        List<IComponent<T>> list;

        public Composite(T name) {
            Name = name;
            list = new List<IComponent<T>>();
        }

        public void Add(IComponent<T> component)
        {
            list.Add(component);
        }

        IComponent<T> holder = null;

        public IComponent<T> Remove(T component)
        {
            holder = this;
            IComponent<T> p = holder.Find(component);
            (holder as Composite<T>).list.Remove(p);
            return holder;
        }

        public string Display(int Depth)
        {
            StringBuilder s = new StringBuilder(new String('-', Depth));
            s.Append("Set " + Name + " length : " + list.Count + "\n");

            foreach (IComponent<T> component in list) {
                s.Append(component.Display(Depth + 2));
            }

            return s.ToString();
        }

        public IComponent<T> Find(T component)
        {
            holder = this;
            if (Name.Equals(component)) return this;

            IComponent<T> found = null;

            foreach (IComponent<T> c in list) {
                found = c.Find(component);
                if (found != null) {
                    break;
                }
            }

            return found;
        }

        public T Name {get; set;}

    }
}
