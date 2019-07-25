using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Samples.BehavioralPatterns.General;
using Samples.BehavioralPatterns.Strategy;

namespace Samples.BehavioralPatterns
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Strategy Pattern
            /* The Context will often contain a switch statement or a cascading if statement,
                where information is processed to reach a decision on which Strategy to adopt.
                    • If the strategies are simple methods, they can be implemented without enclosing
                        classes, and the delegate mechanism can be used to hook the chosen Strategy
                        into the Context at runtime.
                    • Extension methods can be used to define new strategies independently of the
                        original classes that they support.
             * Use the Strategy pattern when
                    • Many related classes differ only in their behavior.
                    • There are different algorithms for a given purpose, and the selection criteria can be codified.
                    • The algorithm uses data to which the client should not have access.
             */
            PolicyRequest request = new PolicyRequest() { 
                Amount = 100000,
                ProductType = ProductType.WHOLE_LIFE,
                ServiceType = PolicyServiceType.FAST_TRACK
            };

            IPolicyServeStrategy srategyProduct1;
            srategyProduct1 = GetStrategyProduct(request);

            Console.WriteLine("");
            Console.WriteLine("========================Strategy Pattern==============================");
            Console.WriteLine("");
            Console.WriteLine("Whole Life Product with Fast Track Premium : " + srategyProduct1.Product.CalculatePremium().ToString("C"));

            request.ServiceType = PolicyServiceType.STANDARD;
            IPolicyServeStrategy srategyProduct2;
            srategyProduct2 = GetStrategyProduct(request);

            Console.WriteLine("");
            Console.WriteLine("Whole Life Product with Standard Premium : " + srategyProduct2.Product.CalculatePremium().ToString("C"));

            #endregion.

            Console.ReadKey();
        }

        static IPolicyServeStrategy GetStrategyProduct(PolicyRequest request){
            
            if (request.ServiceType.Equals(PolicyServiceType.FAST_TRACK)){
                return new FastTrackService(request);
            }

            return new StandardService(request);            
        }
    }
}
