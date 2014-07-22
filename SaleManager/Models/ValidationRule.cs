using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SaleManager.Models
{
    public class ValidationRule
    {
        public string ErrorMessage { get; private set; }

        public ValidationRule(string errorMessage)
        {
            ErrorMessage = errorMessage;
        }
    }
}
