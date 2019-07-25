using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Samples.StructuralPatterns.Bridge
{
    public class LifeProduct : Product
    {
        public decimal AnnualPremium {
            get {
                return base.GetAnnualPremium();
            }
        }

        public decimal MonthlyPremium {
            get {
                return base.GetMonthlyPremium();
            }
        }

    }
}
