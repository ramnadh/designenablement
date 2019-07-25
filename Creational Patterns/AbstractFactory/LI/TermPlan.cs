using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Samples.StructuralPatterns;

namespace Samples.CreationalPatterns.AbstractFactory
{
    public class TermPlan : ITermProduct
    {
        public int IssueAge { get; set; }

        public bool IsSmoker { get; set; }

        public double Benefit { get; set; }

        public decimal CalculatePremium()
        {
            return Math.Round(Convert.ToDecimal(0.045 * (this.Benefit / 100)), 2);
        }    
    }
}
