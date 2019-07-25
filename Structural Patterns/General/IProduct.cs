using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Samples.StructuralPatterns
{
    public interface IProduct
    {
        double Benefit { get; set; }        
        decimal CalculatePremium();
    }
}
