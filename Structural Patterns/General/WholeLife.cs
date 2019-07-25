using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Samples.StructuralPatterns.General
{
    [Serializable()]
    public class WholeLife : IProduct
    {
        public int IssueAge { get;set;}
        public bool IsSmoker { get; set; }
        public double DeathBenefitAmount { get; set; }
        public double Benefit {
            get {
                return this.DeathBenefitAmount;
            }
            set {
                this.DeathBenefitAmount = value;
            }
        }

        public int TermYears { get; set; }
        public double PremiumRate
        {
            get
            {
                return premiumRate;
            }
            set {
                premiumRate = value;
            }
        }

        private double premiumRate = 0.023;

        public decimal CalculatePremium() { 
            // premium logic based on the business rules and the attributes
            return Math.Round(Convert.ToDecimal(premiumRate * (this.DeathBenefitAmount / 100)), 2);
        }
    }
}
