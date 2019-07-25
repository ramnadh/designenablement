using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Samples.StructuralPatterns;

namespace Samples.CreationalPatterns.AbstractFactory
{
    public class Client<ProductType> where ProductType : IProduct, new ()
    {
        public IDIProduct DIClientMain() {
            IFactory<ProductType> factory = new Factory<ProductType>();
            return factory.GetDIProduct();
        }

        public ILifeProduct LifeClientMain()
        {
            IFactory<ProductType> factory = new Factory<ProductType>();
            return factory.GetLifeProduct();
        }

        //public void ClientMain() {

        //    IFactory<ProductType> factory = new Factory<ProductType>();

        //    IDIProduct diProduct = factory.GetDIProduct();
        //}
    }
}
