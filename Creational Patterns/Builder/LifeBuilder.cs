using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Samples.StructuralPatterns.General;
using Samples.CreationalPatterns.General;

namespace Samples.CreationalPatterns.Builder
{
    public class LifeBuilder : IBuilder
    {
        Product liProduct;
        ProductRequest request;

        public LifeBuilder(ProductRequest request)
        {
            this.request = request;
            this.BuildRiders();
            this.BuildDiscounts();
        }

        public void BuildRiders()
        {
            switch (request.ProductType)
            {
                case StructuralPatterns.Common.ProductTypes.WholeLife:
                    liProduct = new WholeLifeExtended() { Benefit = request.Amount};
                    liProduct.Riders.Add(new ChildRider() { CoverageAmount = 80000, KidAge = 6 });
                    liProduct.Riders.Add(new ChildRider() { CoverageAmount = 90000, KidAge = 10 });
                    break;
            }
        }

        public void BuildDiscounts()
        {
            switch (request.ProductType)
            {
                case StructuralPatterns.Common.ProductTypes.WholeLife:
                    liProduct.Discount = 0.05;
                    break;
            }
        }

        public Product InsuranceProduct
        {
            get { return liProduct; }
        }
    }
}

