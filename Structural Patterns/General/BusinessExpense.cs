using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Linq;
using System.Text;

namespace Samples.StructuralPatterns.General
{
    [Serializable()]
    public class BusinessExpense : IProduct
    {
        public int IssueAge { get; set; }
        public bool IsSmoker { get; set; }
        public double BenefitAmount { get; set; }
        public int BenefitPeriod { get; set; }

        public double Benefit
        {
            get
            {
                return this.BenefitAmount;
            }
            set {
                this.BenefitAmount = value;
            }
        }

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


        private double premiumRate = 0.042;

        public decimal CalculatePremium()
        {
            // premium logic based on the business rules and the attributes
            return Math.Round(Convert.ToDecimal(premiumRate * (this.BenefitAmount / 100)), 2);
        }
    }
}
