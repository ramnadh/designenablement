using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Samples.StructuralPatterns.Composite
{
    public abstract class LifeProducts : IProduct
    {
        List<IProduct> products;

        public LifeProducts(List<IProduct> products) {
            this.products = products;
        }

        public void Add(IProduct product) {
            products.Add(product);
        }

        public void Remove(IProduct product) {
            products.Remove(product);
        }

        public decimal CalculatePremium() {
            decimal totalPremiumAmount = 0;

            foreach (IProduct product in products) {
                totalPremiumAmount += product.CalculatePremium();
            }
            return totalPremiumAmount;
        }

        public decimal TotalPremiumAmount { get { return this.CalculatePremium(); } }

        public double Benefit { get; set; }
    }
}
