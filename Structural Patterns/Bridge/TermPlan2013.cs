using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Samples.StructuralPatterns.Bridge
{
    public class TermPlan2013 : IProduct
    {
        public double Benefit { get; set; }

        double premiumRate = 0.23;

        public decimal CalculatePremium() {
            // premium logic based on the business rules and the attributes
            return Math.Round(Convert.ToDecimal(premiumRate * (this.Benefit / 100)), 2);
        }
    }
}
