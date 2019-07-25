using System;
using Samples.StructuralPatterns.General;

namespace Samples.StructuralPatterns.Proxy
{
    public interface ICreateProduct
    {
        IProduct CreateProduct(ProductRequest productRequest);
    }
}
