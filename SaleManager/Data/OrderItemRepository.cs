using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SaleManager.Models.Interfaces;
using SaleManager.db;

namespace SaleManager.Data
{
    public class OrderItemRepository : IOrderItemRepository
    {
        public IQueryable<OrderItem> GetAll()
        {
            return db.OrderItem.All();
        }

        public OrderItem GetById(int Id)
        {
            return OrderItem.SingleOrDefault(e => e.id == Id);
        }

        public IQueryable<OrderItem> GetAllByOrderId(int orderId)
        {
            var orderItems = (from oi in db.OrderItem.All()
                              join si in Seller.All() on oi.sellerId equals si.id
                              where oi.orderId == orderId
                              select new OrderItem()
                              {
                                id = oi.id,
                                sellerId = oi.sellerId,
                                orderId = oi.orderId,
                                price = oi.price,
                                description = oi.description,
                                SellerName = si.name
                              });

            return orderItems.AsQueryable<OrderItem>();
        }
                            
        public void Add(OrderItem orderItem)
        {
            OrderItem oi = new OrderItem();
            oi.orderId = orderItem.orderId;
            oi.sellerId = orderItem.sellerId;
            oi.price = orderItem.price;
            oi.description = orderItem.description;
            oi.Save();
        }

        public void Edit(OrderItem orderItem)
        {
            OrderItem oi = OrderItem.SingleOrDefault(e => e.id == orderItem.id);

            if (oi != null)
            {
                oi.price = orderItem.price;
                oi.sellerId = orderItem.sellerId;
                oi.description = orderItem.description;
                oi.Save();
            }
        }

        public void Remove(int id)
        {
            OrderItem oi = OrderItem.SingleOrDefault(e => e.id == id);

            if (oi != null)
            {
                oi.Delete();
            }
        }
    }
}