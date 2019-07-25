using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Samples.StructuralPatterns.General;

namespace Samples.StructuralPatterns.Facade
{
    public class ProductDefinition
    {
        ProductRequest product;        

        public ProductDefinition(ProductRequest product) {
            this.product = product;
            GetPremiumRate();
        }

        public ProductRequest Product {
            get { return product; }
        }

        public void GetPremiumRate() {
            switch (product.ProductType) { 
                case Common.ProductTypes.WholeLife:
                    if (product.IssueAge >= 50 && product.IssueAge <= 60) {
                        product.PremiumRate = 0.23;
                    }
                    else if (product.IsSmoker)
                    {
                        product.PremiumRate = 0.01;
                    }
                    else
                    {
                        product.PremiumRate = 0.243;
                    }
                    break;
                case Common.ProductTypes.BusinessExpense:
                    if (product.IsSmoker) {
                        product.PremiumRate = 0.012;
                    }
                    else if (product.IssueAge >= 35 && product.IssueAge <= 50)
                    {
                        product.PremiumRate = 0.25;
                    }
                    else
                    {
                        product.PremiumRate = 0.23;
                    }
                    break;
            }            
        }
    }
}
