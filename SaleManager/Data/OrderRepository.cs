using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SaleManager.Models.Interfaces;
using SaleManager.db;

namespace SaleManager.Data
{
    public class OrderRepository : IOrderRepository
    {
        public Order Create(int saleId, string orderNumber)
        {
            Order order = Order.SingleOrDefault(e => e.complete == 0);

            if (order == null)
            {
                Order newOrder = new Order();
                newOrder.saleId = saleId;
                newOrder.number = orderNumber;
                newOrder.complete = 0;
                newOrder.total = 0;
                newOrder.Save();

                order = newOrder;
            }
 
            return order;
        }

        public void Complete(int id)
        {
            double orderTotal = GetTotal(id);
            Order order = Order.SingleOrDefault(e => e.id == id);
            order.complete = 1;
            order.total = orderTotal;
            order.Save();
        }

        public double GetTotal(int orderId)
        {
            double total = 0;
            List<OrderItem> orderItems = OrderItem.Find(e => e.orderId == orderId).ToList();

            foreach (OrderItem orderItem in orderItems)
            {
                total += orderItem.price;
            }

            return total;
        }

        public bool HasOpenOrder()
        {
            Order order = Order.SingleOrDefault(e => e.complete == 0);

            return order != null;
        }

        public void Cancel()
        {
            Order order = Order.SingleOrDefault(e => e.complete == 0);

            if (order != null)
            {
                List<OrderItem> items = OrderItem.Find(e => e.orderId == order.id).ToList();

                foreach (OrderItem item in items)
                {
                    item.Delete();
                }

                order.Delete();
            }
        }

        public IList<Order> GetCompletedOrdersBySaleId(int saleId)
        {
            ///return Order.Find(e => e.saleId == saleId && e.complete == 1).AsQueryable();
            var orders = (from o in Order.All()
                         where o.complete == 1 && o.saleId == saleId
                         orderby o.id
                         select new Order()
                         {
                             total = o.total,
                             number = o.number,
                             id = o.id,
                             saleId = o.saleId,
                             complete = o.complete
                         }).ToList();

            return orders;                      
        }

        public Order GetById(int id)
        {
            return Order.SingleOrDefault(e => e.id == id);
        }

        public IQueryable<Order> GetAll()
        {
            return Order.All();
        }
    }
}
