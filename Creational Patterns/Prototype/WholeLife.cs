using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Samples.CreationalPatterns.General;

namespace Samples.CreationalPatterns.Prototype
{
    //Prototype
    [Serializable()]
    public class WholeLife : Prototype<WholeLife>
    {
        public int IssueAge { get; set; }
        public bool IsSmoker { get; set; }
        public double DeathBenefitAmount { get; set; }

        public List<ChildRider> ChildRiders { get; set; }

        public double Benefit
        {
            get
            {
                return this.DeathBenefitAmount;
            }
            set
            {
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
            set
            {
                premiumRate = value;
            }
        }

        private double premiumRate = 0.023;

        public decimal CalculatePremium()
        {
            // premium logic based on the business rules and the attributes
            decimal prem = Math.Round(Convert.ToDecimal(premiumRate * (this.DeathBenefitAmount / 100)), 2);
            foreach (ChildRider rider in ChildRiders) {
                prem += rider.CalculatePremium();
            }
            return prem;
        }
    }
}
