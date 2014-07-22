using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SaleManager.Models.Interfaces;
using SaleManager.Models;

namespace SaleManager.db
{
    public partial class OrderItem : IValidator
    {
        public string SellerName { get; set; }

        public OrderItem(double p, string name, string desc)
        {
            this.price = p;
            this.SellerName = name;
            this.description = desc;
        }

        public bool IsValid
        {
            get
            {
                return Validator().ErrorMessage.Length == 0;
            }
        }

        public ValidationRule Validator()
        {
            if (this.price == null || this.price.ToString().Length == 0)
            {
                return new ValidationRule("Price is required.");
            }
            if (this.sellerId == null || this.sellerId == 0)
            {
                return new ValidationRule("Seller is required.");
            }

            return new ValidationRule(string.Empty);
        }
    }
}
