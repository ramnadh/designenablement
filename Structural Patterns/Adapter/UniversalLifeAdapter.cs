using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Samples.StructuralPatterns.Adapter
{
    public class UniversalLifeAdapter : ISFUniversalLife
    {
        StateFarmUniversalLife sfULProduct = new StateFarmUniversalLife();

        private bool IsPersonSmoker(SmokingClass smkClass)
        {
            switch (smkClass) { 
                case SmokingClass.Preferred:
                case SmokingClass.SuperPreferred:
                case SmokingClass.UltraStandard:
                case SmokingClass.Standard:
                    return false;
                case SmokingClass.PreferredTobacco:
                case SmokingClass.Tobacoo:
                    return true;
            }

            return false;
        }

        public int IssueAge
        {
            get
            {
                return sfULProduct.GetAge();
            }
            set
            {
                sfULProduct.SetAge(value);
            }
        }

        public bool IsSmoker
        {
            get
            {
                return IsPersonSmoker(sfULProduct.GetSmokingClass());
            }
            set
            {
                SmokingClass smkclass;

                if (value)
                    smkclass = SmokingClass.Tobacoo;
                else
                    smkclass = SmokingClass.Preferred;

                sfULProduct.SetSmokingClass(smkclass);
            }
        }

        public double Amount
        {
            get
            {
                return sfULProduct.GetAmount();
            }
            set
            {
                sfULProduct.SetAmount(value);
            }
        }

        public decimal CalculatePremium()
        {
            return sfULProduct.SFAnnualPremium;
        }

        public decimal GetMonthlyPremium() {
            return sfULProduct.SFMonthlyPremium;
        }
    }
}
