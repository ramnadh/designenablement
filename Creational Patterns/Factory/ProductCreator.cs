using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Samples.StructuralPatterns;
using Samples.StructuralPatterns.General;

namespace Samples.CreationalPatterns.Factory
{
    public class ProductCreator
    {
        public ProductCreator() { 
        }

        public IProduct GetFactoryProduct(ProductRequest request) {
            switch (request.ProductType) { 
                case Common.ProductTypes.WholeLife:
                    //you can write business rules here to create a whole life object based on request object
                    return new WholeLife() { DeathBenefitAmount = request.Amount,IsSmoker = request.IsSmoker,IssueAge = request.IssueAge };
                case Common.ProductTypes.BusinessExpense:
                    //you can write business rules here to create a business expense object based on request object
                    return new BusinessExpense() { BenefitAmount = request.Amount, IsSmoker = request.IsSmoker, IssueAge = request.IssueAge };
            }

            return null;
        }
    }
}
