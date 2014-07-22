using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SaleManager.db;

namespace SaleManager.Models.Interfaces
{
    public interface ISaleRepository : IRetrieve<Sale>
    {
        Sale GetOpenSale();
        bool IsOpen { get; }
        void Open();
        void Close();
    }
}
