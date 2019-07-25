using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Samples.BehavioralPatterns.General
{
    public class PolicyRequest
    {
        public double Amount { get; set; }

        public ProductType ProductType { get; set; }

        public PolicyServiceType ServiceType { get; set; }

    }
}
