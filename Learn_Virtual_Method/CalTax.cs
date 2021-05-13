using System;
using System.Collections.Generic;
using System.Text;

namespace Learn_Virtual_Method
{
    class CalTax : Tax
    {
        public override void Calculate_Tax(int grosspay)
        {
            _taxRate = 0.0M;
            _slab = "Tax Exempation";
        }
    }
}
