using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SaleManager.db;

namespace SaleManager.Models.Interfaces
{
    public interface IOrderRepository : IRetrieve<Order>
    {
        Order Create(int saleId, string orderNumber);
        void Complete(int id);
        void Cancel();
        double GetTotal(int id);
        bool HasOpenOrder();
        IList<Order> GetCompletedOrdersBySaleId(int saleId);
        
    }
}
