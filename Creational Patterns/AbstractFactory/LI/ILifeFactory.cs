using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Samples.StructuralPatterns;

namespace Samples.CreationalPatterns.AbstractFactory
{
    public interface ILifeFactory
    {
        ITermProduct GetTermProduct(bool isCurrentProduct);
        ILifeProduct GetLifeProduct();
    }
}