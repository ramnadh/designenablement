using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Linq;
using System.Text;

namespace Samples.CreationalPatterns.General
{
    [Serializable()]
    public class ChildRider
    {
        public int KidAge { get; set; }
        public double CoverageAmount { get; set; }

        public decimal CalculatePremium() {
            return Math.Round(Convert.ToDecimal(0.23 * (this.CoverageAmount/ 100)), 2);
        }
    }
}
