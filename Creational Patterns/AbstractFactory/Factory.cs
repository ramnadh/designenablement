using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Samples.StructuralPatterns;

namespace Samples.CreationalPatterns.AbstractFactory
{
    public class Factory<ProductType>: IFactory<ProductType> where ProductType : IProduct, new()
    {
        public IDIProduct GetDIProduct() {
            return new DIProduct<ProductType>();
        }

        public ILifeProduct GetLifeProduct() {
            return new LifeProduct<ProductType>();
        }
    }
}
