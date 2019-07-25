using System;
using Samples.StructuralPatterns.Decorator;
using Samples.StructuralPatterns.General;

namespace Samples.StructuralPatterns.Proxy
{
    public class SmokerProxy : ICreateProduct
    {
        public IProduct CreateProduct(ProductRequest request) {
            if (request == null) return null;

            if (request.IsSmoker && request.IssueAge >= 40) {
                return null;
            }

            if (request.ProductType.Equals(Common.ProductTypes.WholeLife)) return new WholeLife();
            else if (request.ProductType.Equals(Common.ProductTypes.BusinessExpense)) return new BusinessExpense();

            return null;
        }
    }
}
