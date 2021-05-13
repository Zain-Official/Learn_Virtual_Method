using System;
using System.Collections.Generic;
using System.Text;

namespace Learn_Virtual_Method
{
    class Tax
    {
        protected decimal _taxRate = 0;
        protected string _slab = "Tax Exampation";
        public virtual void Calculate_Tax(int grosspay)
        {
            if(grosspay>50000 && grosspay <79999)
            {
                _taxRate = 5.0M;
                _slab = "Slab 1";

            }else if(grosspay>=80000 && grosspay <119999)
            {
                _taxRate = 5.5M;
                _slab = "Slab 2";
            }else if(grosspay>=120000)
            {
                _taxRate = 6.5M;
                _slab = "Slab 3";
            }    

        }
        public decimal gettax
        {
            get
            {
                return _taxRate;
            }
        }

        public string getslab
        {
            get
            {
                return _slab;
            }
        }
    }
}
