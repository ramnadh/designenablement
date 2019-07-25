using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Samples.BehavioralPatterns.Observer
{
    public interface IEmailAlert
    {
        void Update(string state);
    }
}
