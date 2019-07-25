using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Samples.StructuralPatterns.General;
using Samples.CreationalPatterns.General;

namespace Samples.CreationalPatterns.Builder
{
    public class DIBuilder : IBuilder
    {
        Product diProduct;
        ProductRequest request;

        public DIBuilder(ProductRequest request)
        {
            this.request = request;
            this.BuildRiders();
            this.BuildDiscounts();
        }

        public void BuildRiders()
        {
            switch (request.ProductType)
            {
                case StructuralPatterns.Common.ProductTypes.BusinessExpense:
                    diProduct = new BEExtended() { Benefit = request.Amount };
                    diProduct.Riders.Add(new ChildRider() { CoverageAmount = 90000, KidAge = 4 });
                    diProduct.Riders.Add(new ChildRider() { CoverageAmount = 100000, KidAge = 9 });
                    break;
            }
        }

        public void BuildDiscounts()
        {
            switch (request.ProductType)
            {
                case StructuralPatterns.Common.ProductTypes.BusinessExpense:
                    diProduct.Discount = 0.065;
                    break;
            }
        }

        public Product InsuranceProduct
        {
            get { return diProduct; }
        }
    }
}
