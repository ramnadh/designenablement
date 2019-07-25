using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Samples.StructuralPatterns
{
    public class Common
    {
        public struct DiscountValue
        {
            public const decimal PERCENT_25 = 0.25M;
            public const decimal PERCENT_50 = 0.50M;
            public const decimal PERCENT_75 = 0.75M;
        }

        public enum ProductTypes {
            WholeLife = 1,
            BusinessExpense = 2
        }
    }


    public enum SmokingClass : int
    {
        SuperPreferred,
        Preferred,
        UltraStandard,
        Standard,
        PreferredTobacco,
        Tobacoo
    }
}
