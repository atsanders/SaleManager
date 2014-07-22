using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SaleManager.Models.Interfaces
{
    public interface IValidator
    {
        bool IsValid { get; }
        ValidationRule Validator();
    }
}
