using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Samples.StructuralPatterns.Adapter
{
    public interface ISFUniversalLife
    {
        int IssueAge { get; set;}
        bool IsSmoker { get; set; }
        double Amount { get; set; }

        decimal CalculatePremium();
        decimal GetMonthlyPremium();
    }
}
