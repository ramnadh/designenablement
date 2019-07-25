﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Samples.CreationalPatterns.AbstractFactory
{
    public class BE105 : IBusinessExpense
    {
        public int IssueAge { get; set; }

        public bool IsSmoker { get; set; }

        public decimal CalculatePremium()
        {
            return Math.Round(Convert.ToDecimal(0.023 * (this.Benefit / 100)), 2);
        }

        public double Benefit { get; set; }

    }
}
