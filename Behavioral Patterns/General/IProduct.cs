using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Samples.BehavioralPatterns.General
{
    public interface IProduct
    {    
        double Amount { get; set; }

        decimal CalculatePremium();

        double AdditionalCharge { get; set; }
    }
}
