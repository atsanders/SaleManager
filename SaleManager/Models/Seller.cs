using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SaleManager.Models.Interfaces;
using SaleManager.Models;

namespace SaleManager.db
{
    public partial class Seller : IValidator
    {

        public bool IsValid
        {
            get 
            { 
                return Validator().ErrorMessage.Length == 0; 
            }
        }

        public ValidationRule Validator()
        {
            if (this.name == null || this.name.Length == 0)
            {
                return new ValidationRule("Name is required.");
            }

            return new ValidationRule(string.Empty);
        }
    }
}
