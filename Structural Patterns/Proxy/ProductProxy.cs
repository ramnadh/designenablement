using System;
using Samples.StructuralPatterns.Decorator;
using Samples.StructuralPatterns.General;

namespace Samples.StructuralPatterns.Proxy
{
    public class ProductProxy : ICreateProduct
    {
        public IProduct CreateProduct(ProductRequest request) {
            if (request == null) return null;

            if (request.ProductType.Equals(Common.ProductTypes.WholeLife))
            {
                if (request.IssueAge >= 0 && request.IssueAge <= 60)
                {
                    return new WholeLife() { IssueAge = request.IssueAge, DeathBenefitAmount = request.Amount, IsSmoker = request.IsSmoker};
                }
                else {
                    return null;
                }
            }
            else if (request.ProductType.Equals(Common.ProductTypes.BusinessExpense)) {
                if (request.IssueAge >= 18 && request.IssueAge <= 60)
                {
                    return new BusinessExpense();
                }
                else {
                    return null;
                }
            }

            return null;
        }
    }
}
