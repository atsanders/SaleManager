using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SaleManager.Models.Interfaces;
using SaleManager.Data;
using SaleManager.db;

namespace SaleManager.Controllers
{
    public class OrderItemController
    {
        IOrderItemRepository _orderItemRepository;
        public delegate void onItemAddedHandler();
        public static event onItemAddedHandler onItemAdded;

        public OrderItemController()
            : this(new OrderItemRepository())
        {
        }

        public OrderItemController(IOrderItemRepository orderItemRepository)
        {
            _orderItemRepository = orderItemRepository;
        }

        public List<OrderItem> GetAll()
        {
            return _orderItemRepository.GetAll().ToList();
        }

        public List<OrderItem> GetAllByOrderId(int orderId)
        {
            return _orderItemRepository.GetAllByOrderId(orderId).ToList();
        }

        public OrderItem GetById(int id)
        {
            return _orderItemRepository.GetById(id);
        }

        public void Add(OrderItem orderItem)
        {
            _orderItemRepository.Add(orderItem);

            if (onItemAdded != null)
            {
                onItemAdded();
            }
        }

        public void Edit(OrderItem orderItem)
        {
            _orderItemRepository.Edit(orderItem);
        }

        public void Remove(int id)
        {
            _orderItemRepository.Remove(id);
        }
    }
}
