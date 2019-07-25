﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Samples.StructuralPatterns;

namespace Samples.CreationalPatterns.AbstractFactory
{
    public interface ITermProduct : IProduct
    {
        int IssueAge { get; set; }
        bool IsSmoker { get; set; }
    }
}
