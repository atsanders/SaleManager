using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SaleManager.Utility
{
    public class Validators
    {
        private static string _moneyReg = @"^\$?(([1-9]{1}[0-9]{0,2}(\,[0-9]{3}))|[0-9]{1}([0-9]+)?)*(\.[0-9]{0,2})?$";

        public static string Money
        {
            get
            {
                return _moneyReg;
            }
        }
    }
}
