using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Samples.StructuralPatterns.General;

namespace Samples.CreationalPatterns.AbstractFactory
{
    public class DIFactory : IDIFactory
    {
        ProductRequest request;

        public DIFactory(ProductRequest request) {
            this.request = request;
        }

        public IPaycheckProtection GetDIProduct()
        {
            return new DI105() { Benefit = request.Amount, IsSmoker = request.IsSmoker, IssueAge = request.IssueAge};
        }

        public IBusinessExpense GetBEProduct(bool isCurrentProduct)
        {
            if (isCurrentProduct) {
                return new BE2013() { Benefit = request.Amount, IsSmoker = request.IsSmoker, IssueAge = request.IssueAge };
            }
            return new BE105() { Benefit = request.Amount, IsSmoker = request.IsSmoker, IssueAge = request.IssueAge };
        }
    }
}
