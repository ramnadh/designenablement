using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Samples.BehavioralPatterns.General
{
    public class TermPlan : IProduct
    {
        public double Amount { get; set; }

        public double AdditionalCharge { get; set; }

        public decimal CalculatePremium()
        {
            decimal premium = Math.Round(Convert.ToDecimal(0.034 * (this.Amount / 100)), 2);
            return premium + Convert.ToDecimal(AdditionalCharge);
        }

    }
}
