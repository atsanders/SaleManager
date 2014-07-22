using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SaleManager.db;

namespace SaleManager.Models.Interfaces
{
    public interface IStartCashRepository : ICreate<StartCash>, IRetrieve<StartCash>, IUpdate<StartCash>, IDelete<StartCash>
    {
        List<StartCash> GetAllBySaleId(int id);
    }
}
