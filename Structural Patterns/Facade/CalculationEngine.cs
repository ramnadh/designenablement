using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Samples.StructuralPatterns.General;
using Samples.StructuralPatterns.Decorator;

namespace Samples.StructuralPatterns.Facade
{
    public class CalculationEngine
    {
        ProductRequest product;       

        public CalculationEngine(ProductRequest product) {
            this.product = product;
        }

        public decimal CalculatePremium() {
            switch (this.product.ProductType) { 
                case Common.ProductTypes.WholeLife:
                    product.Amount += 1000;
                    WholeLife wl = new WholeLife() { IssueAge = product.IssueAge, IsSmoker = product.IsSmoker, DeathBenefitAmount = product.Amount,PremiumRate = product.PremiumRate };
                    return wl.CalculatePremium();
                case Common.ProductTypes.BusinessExpense:
                    product.Amount += 500;
                    BusinessExpense be = new BusinessExpense() { IssueAge = product.IssueAge, IsSmoker = product.IsSmoker, BenefitAmount = product.Amount, PremiumRate = product.PremiumRate };
                    return be.CalculatePremium();
            }
            return 0;
        }
    }
}
