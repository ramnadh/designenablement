using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Samples.CreationalPatterns.General;
using Samples.CreationalPatterns.Prototype;
using Samples.CreationalPatterns.Factory;
using Samples.StructuralPatterns;
using Samples.CreationalPatterns.AbstractFactory;
using Samples.CreationalPatterns.Builder;

namespace Samples.CreationalPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Prototype Pattern
            /* Use the Prototype pattern when
                    You want to:
                        • Hide concrete classes from the client.
                        • Add and remove new classes (via prototypes) at runtime.
                        • Keep the number of classes in the system to a minimum.
                        • Adapt to changing structures of data at runtime.
             Because:
                    • In C# 3.0, cloning by deep copying is absolutely straightforward.
             Consider using this pattern:
                    • With the Composite pattern, to provide archiving.
                    • Instead of the Factory Method pattern, when subclasses start proliferating
             */

            Console.WriteLine("");
            Console.WriteLine("=================Prototype Pattern=========================");
            WholeLifePremiumIllustrations illustrations = new WholeLifePremiumIllustrations();

            WholeLife wl1 = illustrations.Prototypes["SFWholeLife"].Clone();
            wl1.ChildRiders[0].CoverageAmount = 1000000000;

            WholeLife wl2 = illustrations.Prototypes["IMLWholeLife"].DeepCopy();
            wl2.ChildRiders[0].CoverageAmount = 1000000000;

            Console.WriteLine("");
            Console.WriteLine("SFWholeLife Actual Object Coverage Amount : "+illustrations.Prototypes["SFWholeLife"].ChildRiders[0].CoverageAmount);
            Console.WriteLine("SFWholeLife Cloned Copy Coverage Amount : "+wl1.ChildRiders[0].CoverageAmount);

            Console.WriteLine("");
            Console.WriteLine("IMLWholeLife Actual Object Coverage Amount : "+illustrations.Prototypes["IMLWholeLife"].ChildRiders[0].CoverageAmount);
            Console.WriteLine("IMLWholeLife Deep Copy Object Coverage Amount : " + wl2.ChildRiders[0].CoverageAmount);
            Console.WriteLine("");

            #endregion

            #region Factory Pattern

            /*The Factory Method pattern is a way of creating objects, but letting subclasses
                decide exactly which class to instantiate. Various subclasses might implement the
                interface; the Factory Method instantiates the appropriate subclass based on information
                supplied by the client or extracted from the current state.
             
             Use the Factory Method pattern when
                • Flexibility is important.
                • Objects can be extended in subclasses
                • There is a specific reason why one subclass would be chosen over another—this logic forms part of the Factory
                    Method.
                • A client delegates responsibilities to subclasses in parallel hierarchies.
                Consider using instead....             
                    • The Abstract Factory, Prototype, or Builder patterns, which are more flexible (though also more complex).
                    • The Prototype pattern to store a set of objects to clone from the abstract factory.              
             */

            Samples.StructuralPatterns.General.ProductRequest request = new Samples.StructuralPatterns.General.ProductRequest()
            { 
                Amount = 10000,
                IsSmoker = false,
                IssueAge = 45,
                ProductType = StructuralPatterns.Common.ProductTypes.WholeLife
            };

            ProductCreator creator = new ProductCreator();
            IProduct product = creator.GetFactoryProduct(request);

            Console.WriteLine("=================Factory Pattern=========================");
            Console.WriteLine("");
            Console.WriteLine("Whole Life Product Amount: {0} and Premium: {1}  " , product.Benefit.ToString("C"), product.CalculatePremium().ToString("C"));
            Console.WriteLine("");

            #endregion

            #region Singleton Pattern

            #endregion

            #region Abstract Factory

            /*  Use the Abstract Factory pattern when
                    • A system should be independent of how its products are created, composed, and represented.
                    • A system can be configured with one of multiple families of products.
                    • The constraint requiring products from the same factory to be used together must be enforced.
                    • The emphasis is on revealing interfaces, not implementations.             
             */

            ILifeFactory factory = new LifeFactory(request);
            ILifeProduct lifeproduct = factory.GetLifeProduct();
            ITermProduct tpProduct = factory.GetTermProduct(false);
            ITermProduct ropProduct = factory.GetTermProduct(true);

            Console.WriteLine("");
            Console.WriteLine("==========================Abstract Factory==============================");
            Console.WriteLine("Whole Life Product Premium : " + lifeproduct.CalculatePremium().ToString("C"));
            Console.WriteLine("Term Plan Product Premium : " + tpProduct.CalculatePremium().ToString("C"));
            Console.WriteLine("ROP Product Premium : " + ropProduct.CalculatePremium().ToString("C"));
            Console.WriteLine("");

            IDIFactory difactory = new DIFactory(request);
            IPaycheckProtection diproduct = difactory.GetDIProduct();
            IBusinessExpense beproduct = difactory.GetBEProduct(false);
            IBusinessExpense beproduct1 = difactory.GetBEProduct(true);

            Console.WriteLine("");
            Console.WriteLine("Paycheck protection Product Premium : " + diproduct.CalculatePremium().ToString("C"));
            Console.WriteLine("Business Expense Product Premium : " + beproduct.CalculatePremium().ToString("C"));
            Console.WriteLine("Business Expense 2013 Product Premium : " + beproduct1.CalculatePremium().ToString("C"));
            Console.WriteLine("");

            
            #endregion

            #region Builder Pattern

            Samples.StructuralPatterns.General.ProductRequest request11 = new StructuralPatterns.General.ProductRequest(){
                Amount = 100000,
                IsSmoker = false,
                IssueAge = 34,
                ProductType = Common.ProductTypes.WholeLife
            };

            Samples.StructuralPatterns.General.ProductRequest berequest1 = new StructuralPatterns.General.ProductRequest()
            {
                Amount = 40000,
                IsSmoker = true,
                IssueAge = 45,
                ProductType = Common.ProductTypes.BusinessExpense
            };

            IBuilder builder = new LifeBuilder(request11);

            IBuilder bebuilder = new DIBuilder(berequest1);

            Console.WriteLine("");
            Console.WriteLine("==========================Builder Pattern=============================");
            Console.WriteLine("Created Whole Life Extended product and Calcuated Premium is : "+ builder.InsuranceProduct.CalculatePremium().ToString("C"));
            Console.WriteLine("Created BE Extended product and Calcuated Premium is : " + bebuilder.InsuranceProduct.CalculatePremium().ToString("C"));
            Console.WriteLine("");

            #endregion

            Console.ReadKey();
        }
    }
}