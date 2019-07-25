using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Samples.StructuralPatterns.Composite
{
    public interface IComponent<T>
    {
        void Add(IComponent<T> component);
        IComponent<T> Remove(T component);
        string Display(int Depth);
        IComponent<T> Find(T component);
        T Name { get; set; }
    }
}
