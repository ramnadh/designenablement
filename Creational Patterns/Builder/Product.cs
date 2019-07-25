using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Samples.StructuralPatterns;
using Samples.CreationalPatterns.General;

namespace Samples.CreationalPatterns.Builder
{
    public abstract class Product : IProduct
    {
        public abstract double Benefit {get;set;}

        public abstract decimal CalculatePremium();

        private List<ChildRider> riders = new List<ChildRider>();
        public List<ChildRider> Riders { get { return riders; } set { riders = value; } }

        public double Discount { get; set; }
    }
}
