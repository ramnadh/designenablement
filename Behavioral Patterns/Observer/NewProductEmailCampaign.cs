using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Samples.BehavioralPatterns.Observer
{
    public class NewProductEmailCampaign : IEmailAlert
    {
        Campaign camp;
        string name;
        string state;

        public NewProductEmailCampaign(Campaign camp, string name) {
            this.camp = camp;
            this.name = name;
            camp.Notify += Update;
        }

        public void Update(string campaignState) {
            this.state = campaignState;
            Console.WriteLine(name + " : " + state);
        }
    }
}
