using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Samples.BehavioralPatterns.General;

namespace Samples.BehavioralPatterns.Strategy
{
    public interface IPolicyServeStrategy
    {
        IProduct Product{get;}
    }
}
