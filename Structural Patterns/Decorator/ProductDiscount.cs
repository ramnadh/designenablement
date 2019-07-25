using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Samples.StructuralPatterns.Decorator
{
    public class ProductDiscount : IProduct
    {
        IProduct product;
        decimal discount;

        public double Benefit {
            get {
                return product.Benefit;
            }
            set {
                product.Benefit = value;
            }
       }

        public ProductDiscount(IProduct _product,decimal _discountValue) {
            this.product = _product;
            this.discount = _discountValue;
        }

        public decimal CalculatePremium() {
            decimal basePremium = this.product.CalculatePremium();
            return basePremium - Math.Round((basePremium * this.discount), 2);
        }
    }
}
