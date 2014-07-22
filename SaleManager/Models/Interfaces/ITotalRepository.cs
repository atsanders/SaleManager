using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace SaleManager.Models.Interfaces
{
    public interface ITotalRepository
    {
        IQueryable<Total> GetTotalsBySaleId(int saleId);
    }
}
