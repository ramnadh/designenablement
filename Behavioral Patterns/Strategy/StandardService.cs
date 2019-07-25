using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Samples.BehavioralPatterns.General;

namespace Samples.BehavioralPatterns.Strategy
{
    public class StandardService : IPolicyServeStrategy
    {
        PolicyRequest request;

        public StandardService(PolicyRequest request) {
            this.request = request;
        }

        public General.IProduct Product
        {
            get
            {
                if (request.ProductType.Equals(ProductType.WHOLE_LIFE))
                {
                    return new WholeLife() { Amount = request.Amount };
                }
                else if (request.ProductType.Equals(ProductType.TERM_PLAN))
                {
                    return new TermPlan() { Amount = request.Amount };
                }
                else if (request.ProductType.Equals(ProductType.BUSINESS_EXPENSE))
                {
                    return new BusinessExpense() { Amount = request.Amount };
                }

                return null;
            }
        }

    }
}
