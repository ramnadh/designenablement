using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Samples.CreationalPatterns.AbstractFactory
{
    public class WholeLife2013 : ILifeProduct
    {
        public int IssueAge {get;set;}

        public bool IsSmoker {get;set;}

        public double Benefit {get;set;}

        public decimal CalculatePremium()
        {
            return Math.Round(Convert.ToDecimal(0.063 * (this.Benefit / 100)), 2);
        }
    }
}
