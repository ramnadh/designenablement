using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Samples.StructuralPatterns.General;

namespace Samples.StructuralPatterns.Facade
{
    public class QuotingFacade
    {
        ProductRequest request;

        public QuotingFacade(ProductRequest request) {
            this.request = request;
        }

        public decimal AnnualPremium {
            get
            {
                ProductDefinition definition = new ProductDefinition(request);
                CalculationEngine engine = new CalculationEngine(definition.Product);

                return engine.CalculatePremium();
            }
        }

        public decimal MonthlyPremium {
            get {
                return Math.Round(AnnualPremium * 0.0833M, 2);
            }
        }
    }
}
