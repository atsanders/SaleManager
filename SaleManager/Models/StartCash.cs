using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SaleManager.Models.Interfaces;
using SaleManager.Models;

namespace SaleManager.db
{
    public partial class StartCash : IValidator
    {
        public string SellerName { get; set; }

        public bool IsValid
        {
            get
            {
                return Validator().ErrorMessage.Length == 0;
            }
        }

        public ValidationRule Validator()
        {
            if (this.sellerId == null || this.sellerId == 0)
            {
                return new ValidationRule("Seller is required.");
            }
            if (this.cashAmount == null || this.cashAmount.ToString().Length == 0 || this.cashAmount == 0)
            {
                return new ValidationRule("Amount is invalid. Please enter an amount greater than 0.");
            }

            return new ValidationRule(string.Empty);
        }
    }
}
