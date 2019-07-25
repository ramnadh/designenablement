using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Samples.StructuralPatterns.Decorator;
using Samples.StructuralPatterns.General;
using Samples.StructuralPatterns.Proxy;
using Samples.StructuralPatterns.Bridge;
using Samples.StructuralPatterns.Composite;
using Samples.StructuralPatterns.Adapter;
using Samples.StructuralPatterns.Facade;

namespace Samples.StructuralPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            IProduct product = new WholeLife() { DeathBenefitAmount = 100000, IsSmoker = false,IssueAge=34};

            #region Decorator Pattern
            Console.WriteLine("");
            Console.WriteLine("=================Decorator Pattern====================");
            Console.WriteLine("");
            Console.WriteLine("1. Add new functionality dynamically to existing objects, or remove it ");
            Console.WriteLine("2. There is no one big feature-laden class with all the options in it.");
            Console.WriteLine("3. The decorations are independent of each other");
            Console.WriteLine("4. The decorations can be composed together in a mix-and-match fashion");
            
            Console.WriteLine("");

            //person A, i am giving the Whole Life product without discount
            Console.WriteLine("Person A Benefit Amount: " + product.Benefit);
            Console.WriteLine("Person A should pay premium for Whole Life product: " + product.CalculatePremium().ToString("C"));
            Console.WriteLine("");

            ProductDiscount personBdiscount = new ProductDiscount(product, Common.DiscountValue.PERCENT_25);
            BenefitIncrease presonBBenefitIncrease = new BenefitIncrease(personBdiscount, 1000);
            //person B is a probable lead and offer 25% discount
            // Give additional benefit of $1000 along with discount
            Console.WriteLine("Person B Benefit Amount: " + presonBBenefitIncrease.Benefit);
            Console.WriteLine("Person B should pay premium for Whole Life product with 25% discount: " + personBdiscount.CalculatePremium().ToString("C"));
            Console.WriteLine("");

            ProductDiscount personCdiscount = new ProductDiscount(product, Common.DiscountValue.PERCENT_50);
            BenefitIncrease presonCBenefitIncrease = new BenefitIncrease(personCdiscount, 500);
            //person C has already been a customer to me and i would like to cross-sell with 50% discount as an offer price
            // Give additional discount of $500 along with discount
            Console.WriteLine("Person C Benefit Amount: " + presonCBenefitIncrease.Benefit);
            Console.WriteLine("Person C should pay premium for Whole Life product with 50% discount: " + personCdiscount.CalculatePremium().ToString("C"));
            Console.WriteLine("");

            #endregion

            #region Proxy Pattern
            ProductRequest request1 = new ProductRequest()
            {
                Amount = 100000,
                IsSmoker = false,
                IssueAge = 25,
                ProductType = Common.ProductTypes.WholeLife
            };

            ProductRequest request2 = new ProductRequest()
            {
                Amount = 200000,
                IsSmoker = false,
                IssueAge = 78,
                ProductType = Common.ProductTypes.WholeLife
            };

            /* Virtual proxies: Hands the creation of an object over to another object (useful if the creation process
                                    might be slow or might prove unnecessary)
                Authentication proxies: Checks that the access permissions for a request are correct
                Remote proxies:  Encodes requests and send them across a network
                Smart proxies: Adds to or change requests before sending them on Within the scope of the social networking system mentioned earlier, these map as            
                                follows:
                    • Delaying the creation of a rich environment (virtual proxy)
                    • Logging in users (authentication proxy)
                    • Sending requests across the network (remote proxy)
                    • Performing actions on friends’ books (smart proxy
             * */
            Console.WriteLine("=================Proxy Pattern====================");
            Console.WriteLine("");

            ICreateProduct productCreation = new ProductProxy();
            IProduct wlproduct = productCreation.CreateProduct(request1);

            Console.WriteLine("Created WholeLife product with benefit {0} and Premium {1}: ", wlproduct.Benefit.ToString("C"), wlproduct.CalculatePremium().ToString("C"));

            IProduct wlproduct1 = productCreation.CreateProduct(request2);
            if (wlproduct1 == null)
                Console.WriteLine("Cannot create the Whole life product");

            Console.WriteLine("");

            #endregion

            #region Bridge Pattern

            /*Decouble an abstraction from its implementation, so that both of them can vary independently
             * Use the Bridge pattern when
                You can:
                    • Identify that there are operations that do not always need to be implemented in the same way.
                You want to:
                    • Completely hide implementations from clients.
                    • Avoid binding an implementation to an abstraction directly.
                    • Change an implementation without even recompiling an abstraction.
                    • Combine different parts of a system at runtime.
             */

            IProduct termPlan = new TermPlan() { Benefit = 200000 };
            IProduct tp2013 = new TermPlan2013() { Benefit = 200000 };

            LifeProduct liProduct = new LifeProduct();
            liProduct.AssociatedProduct = termPlan;

            Console.WriteLine("=================Bridge Pattern====================");
            Console.WriteLine("");

            Console.WriteLine("Term Plan");
            Console.WriteLine("Term Plan Annual Premium is : " + liProduct.AnnualPremium.ToString("C"));
            Console.WriteLine("Term Plan Monthly Premium is : " + liProduct.MonthlyPremium.ToString("C"));
            Console.WriteLine("");

            liProduct.AssociatedProduct = tp2013;

            Console.WriteLine("");
            Console.WriteLine("Term Plan 2013");
            Console.WriteLine("Term Plan Annual Premium is : " + liProduct.AnnualPremium.ToString("C"));
            Console.WriteLine("Term Plan Monthly Premium is : " + liProduct.MonthlyPremium.ToString("C"));
            Console.WriteLine("");
            #endregion

            #region Composite Pattern
            /*Use the Composite pattern when
                You have:
                        • An irregular structure of objects and composites of the objects
                You want:
                        • Clients to ignore all but the essential differences between individual objects and composites of objects
                        • To treat all objects in a composite uniformly
                        But consider using as well:
                        • The Decorator pattern to provide operations like Add, Remove, and Find
                        • The Flyweight pattern to share components, provided the notion of “where I am” can be disregarded and all
                        operations start at the root of the composite
                        • The Visitor pattern to localize the operations that are currently distributed between the Composite and
                        Component classes
             */
            Console.WriteLine("=================Composite Pattern====================");
            Console.WriteLine("");

            List<IProduct> products = new List<IProduct>();
            products.Add(new WholeLife() { DeathBenefitAmount = 100000, IssueAge= 24, IsSmoker = false});
            products.Add(new WholeLife() { DeathBenefitAmount = 200000, IssueAge = 29, IsSmoker = true});

            List<IProduct> bProducts = new List<IProduct>();
            bProducts.Add(new BusinessExpense(){ BenefitAmount=100000,IsSmoker=false,IssueAge=34});
            bProducts.Add(new BusinessExpense(){ BenefitAmount=200000,IsSmoker=true,IssueAge=39});

            FamilyProtection protectionPack = new FamilyProtection(products);
            Console.WriteLine("Family Protection Pack premium : " + protectionPack.PremiumAmount.ToString("C"));

            Console.WriteLine("");
            BusinessProtection bProtectionPack = new BusinessProtection(bProducts);
            Console.WriteLine("Business Protection Pack premium: " + bProtectionPack.PremiumAmount.ToString("C"));

            Console.WriteLine("");
            #endregion

            #region Adapter Pattern
            /* Convert the interface of a class into another interface clients expect. 
             * Adapter lets classes work together that couldn’t otherwise because of incompatible interfaces
             *Use the Adapter pattern when
                You have:
                    • A domain-specific interface.
                    • A class to connect to with a mismatching interface.
                You want to:
                    • Create a reusable class to cooperate with yet-to-be-built classes.
                    • Change the names of methods as called and as implemented.
                    • Support different sets of methods for different purposes.
              Choose the Adapter you need
                    Class adapter
                        Simple and versatile, invisible to the client.
                    Object adapter
                        Extensible to subclasses of the adapter.
                    Two-way adapter
                        Enables different clients to view an object differently.
                    Pluggable adapter
                        Presence of adapter is transparent; it can be put in and taken out
                        Several adapters can be active.
             */
            ISFUniversalLife ulProduct = new UniversalLifeAdapter()
            {
                IssueAge = 35,
                IsSmoker = false,
                Amount = 100000
            };

            Console.WriteLine("=================Adapter Pattern====================");
            Console.WriteLine("");
            Console.WriteLine("State Farm Universal Life Product Premiums ");
            Console.WriteLine("Universal Life Product Annual Premium : " + ulProduct.CalculatePremium().ToString("C"));
            Console.WriteLine("Universal Life Product Monthly Premium : " + ulProduct.GetMonthlyPremium().ToString("C"));
            Console.WriteLine("");

            #endregion

            #region Facade Pattern
            /*Façade pattern is to provide different high-level views of subsystems whose details are hidden from users.
              Use the Façade pattern when
                A system has several identifiable subsystems and:
                    • The abstractions and implementations of a subsystem are tightly coupled.
                    • The system evolves and gets more complex, but early adopters might want to retain their simple views.
                    • You want to provide alternative novice, intermediate, and “power user” interfaces.
                    • There is a need for an entry point to each level of layered software.
               But consider using instead:
                    • The Abstract Factory pattern for designs where subsystems create objects on behalf of the client.
               Choose the Façade you need
                Opaque
                    Subsystem operations can only be called through the Façade.
                Transparent
                    Subsystem operations can be called directly as well as through the Façade.
                Singleton
                    Only one instance of the Façade is meaningful.
             */
            ProductRequest wlrequest = new ProductRequest(){
                Amount = 100000,
                IsSmoker = false,
                IssueAge = 34,
                ProductType = Common.ProductTypes.WholeLife
            };

            ProductRequest berequest = new ProductRequest()
            {
                Amount = 40000,
                IsSmoker = true,
                IssueAge = 45,
                ProductType = Common.ProductTypes.BusinessExpense
            };

            Console.WriteLine("============================Facade Pattern===========================");
            Console.WriteLine("");
            QuotingFacade quoteFacade = new QuotingFacade(wlrequest);
            Console.WriteLine("Whole Life Annual Premium : "+ quoteFacade.AnnualPremium.ToString("C"));
            Console.WriteLine("Whole Life Monthly Premium : " + quoteFacade.MonthlyPremium.ToString("C"));

            Console.WriteLine("");
            QuotingFacade quoteFacade2 = new QuotingFacade(berequest);
            Console.WriteLine("Business Expense Annual Premium : " + quoteFacade.AnnualPremium.ToString("C"));
            Console.WriteLine("Business ExpenseMonthly Premium : " + quoteFacade.MonthlyPremium.ToString("C"));
            Console.WriteLine("");
            #endregion

            Console.ReadKey();
        }        
    }
}
