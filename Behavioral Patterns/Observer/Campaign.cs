using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Samples.BehavioralPatterns.Observer
{
    public class Campaign
    {
        public delegate void Callback(string s);

        public event Callback Notify;

        public string CampaignState {get;set;}
        
        public void Go() {
            new Thread(new ThreadStart(Run)).Start();
        }

        void Run() { 
            
        }
    }
}
