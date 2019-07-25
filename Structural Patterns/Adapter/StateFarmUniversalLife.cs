using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Samples.StructuralPatterns.Adapter
{
    public class StateFarmUniversalLife
    {
        private int Age { get; set; }
        private SmokingClass SmokingClass { get; set; }
        public double Amount { get; set; }

        private double premiumRate = 0.045;

        public void SetAmount(double amount) {
            this.Amount = amount;
        }

        public double GetAmount() {
            return this.Amount;
        }

        public void SetAge(int age) {
            this.Age = age;
        }

        public int GetAge() {
            return this.Age;
        }

        public void SetSmokingClass(SmokingClass smokeClass)
        {
            this.SmokingClass = smokeClass;
        }

        public SmokingClass GetSmokingClass() {
            return this.SmokingClass;
        }

        public decimal SFAnnualPremium { get { return this.CalculatePremium(); } }

        public decimal SFMonthlyPremium { get { return this.CalculatePremium() * 0.0833M; } }

        private decimal CalculatePremium() {
            return Math.Round(Convert.ToDecimal(premiumRate * (this.Amount / 100)), 2);
        }
    }
}
