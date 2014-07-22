using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SaleManager.db;

namespace SaleManager.Models.Interfaces
{
    public interface IOrderItemRepository : ICreate<OrderItem>, IRetrieve<OrderItem>, IUpdate<OrderItem>, IDelete<OrderItem>
    {
        IQueryable<OrderItem> GetAllByOrderId(int orderId);
    }
}
