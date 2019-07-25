using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Samples.CreationalPatterns.AbstractFactory
{
    public interface IDIFactory
    {
        IPaycheckProtection GetDIProduct();
        IBusinessExpense GetBEProduct(bool isCurrentProduct);
    }
}
