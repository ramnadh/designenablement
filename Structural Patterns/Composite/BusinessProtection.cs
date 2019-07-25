using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Samples.StructuralPatterns.Composite
{
    public class BusinessProtection : LifeProducts
    {
         public BusinessProtection(List<IProduct> products) : base(products)
         {            
        }

        public decimal PremiumAmount {
            get
            {
                decimal totalAmount = 0;
                totalAmount = Math.Round(base.TotalPremiumAmount - (base.TotalPremiumAmount * 0.25M), 2);
                return totalAmount;
            }
        }
    }
}
