using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Samples.CreationalPatterns.Builder
{
    public class WholeLifeExtended : Product
    {
        public override double Benefit {get;set;}

        public override decimal CalculatePremium()
        {
            decimal premium = Math.Round(Convert.ToDecimal(0.039 * (this.Benefit / 100)), 2);
            return premium - (premium * Convert.ToDecimal(this.Discount));
        }
    }
}
