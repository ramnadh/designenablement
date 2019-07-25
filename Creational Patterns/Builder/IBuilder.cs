using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Samples.CreationalPatterns.General;

namespace Samples.CreationalPatterns.Builder
{
    public interface IBuilder
    {
       void BuildRiders();
       void BuildDiscounts();       
       Product InsuranceProduct { get; }
    }
}
