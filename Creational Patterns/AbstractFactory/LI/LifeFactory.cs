using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Samples.StructuralPatterns.General;

namespace Samples.CreationalPatterns.AbstractFactory
{
    public class LifeFactory : ILifeFactory
    {
        ProductRequest request;

        public LifeFactory(ProductRequest request) {
            this.request = request;
        }

        public ITermProduct GetTermProduct(bool isCurrentProduct)
        {
            if (isCurrentProduct) {
                return new TermPlan() { IssueAge = request.IssueAge, IsSmoker = request.IsSmoker, Benefit = request.Amount };
            }
            return new ROP() { IssueAge = request.IssueAge, IsSmoker = request.IsSmoker, Benefit = request.Amount };
        }

        public ILifeProduct GetLifeProduct()
        {
            return new WholeLife2013() { IssueAge = request.IssueAge, IsSmoker = request.IsSmoker, Benefit = request.Amount };
        }
    }
}
