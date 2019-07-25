using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Samples.StructuralPatterns.General
{
    public class ProductRequest
    {
        public int IssueAge { get; set; }
        public bool IsSmoker { get; set; }
        public double Amount { get; set; }
        public double PremiumRate { get; set; }
        public Common.ProductTypes ProductType { get; set; }
    }
}
