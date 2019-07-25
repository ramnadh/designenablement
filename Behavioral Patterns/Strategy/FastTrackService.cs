using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Samples.BehavioralPatterns.General;

namespace Samples.BehavioralPatterns.Strategy
{
    public class FastTrackService : IPolicyServeStrategy
    {
        PolicyRequest request;

        public FastTrackService(PolicyRequest request) {
            this.request = request;
        }

        public General.IProduct Product
        {
            get
            {
                double additionalPremium = GetAdditionalPremium(request.ServiceType);

                if (request.ProductType.Equals(ProductType.WHOLE_LIFE))
                {
                    return new WholeLife() { Amount = request.Amount, AdditionalCharge = additionalPremium };
                }
                else if (request.ProductType.Equals(ProductType.TERM_PLAN))
                {
                    return new TermPlan() { Amount = request.Amount, AdditionalCharge = additionalPremium };
                }
                else if (request.ProductType.Equals(ProductType.BUSINESS_EXPENSE))
                {
                    return new BusinessExpense() { Amount = request.Amount, AdditionalCharge = additionalPremium };
                }

                return null;
            }
        }

        private double GetAdditionalPremium(PolicyServiceType serviceType) {
            
            if (serviceType.Equals(PolicyServiceType.FAST_TRACK)){
                return 0.23;
            }
            else if (serviceType.Equals(PolicyServiceType.STANDARD)) {
                return 0.002;
            }            

            return 0;
        }    
    }
}
