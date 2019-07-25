using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Samples.StructuralPatterns
{
    public abstract class Product
    {
        public IProduct AssociatedProduct { get; set; }

        public decimal GetAnnualPremium() {
            return AssociatedProduct.CalculatePremium() * 1;
        }

        public decimal GetMonthlyPremium() {
            return AssociatedProduct.CalculatePremium() * 0.0833M;
        }
    }
}
