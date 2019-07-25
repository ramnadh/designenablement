using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Samples.CreationalPatterns.General;

namespace Samples.CreationalPatterns.Prototype
{
    //Prototype Manager
    public class WholeLifePremiumIllustrations
    {
        private Dictionary<string, WholeLife> prototypes = new Dictionary<string, WholeLife>();

        public Dictionary<string, WholeLife> Prototypes { get { return prototypes; } }

        public WholeLifePremiumIllustrations() {
            prototypes.Add("SFWholeLife", new WholeLife() { DeathBenefitAmount = 100000, IsSmoker = false, IssueAge = 34, ChildRiders = new List<ChildRider>() { new ChildRider() { CoverageAmount = 50000, KidAge = 4 } } });
            prototypes.Add("IMLWholeLife", new WholeLife() { DeathBenefitAmount = 200000, IsSmoker = true, IssueAge = 43, ChildRiders = new List<ChildRider>() { new ChildRider() { CoverageAmount = 10000, KidAge = 5 } } });
        }        
    }
}
