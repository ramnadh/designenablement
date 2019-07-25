using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Samples.StructuralPatterns.Decorator
{
    public class BenefitIncrease : IProduct
    {
        IProduct product;       

        public double Benefit {
            get {
                return product.Benefit;
            }
            set {
                product.Benefit = value;
            }
        }
        
        public BenefitIncrease(IProduct _product, double increaseAmount) {
            this.product = _product;
            this.product.Benefit = _product.Benefit + increaseAmount;
        }

        public decimal CalculatePremium() {
            return product.CalculatePremium();
        }
    }
}
