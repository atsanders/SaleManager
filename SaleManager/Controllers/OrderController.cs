using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SaleManager.Models.Interfaces;
using SaleManager.Data;
using SaleManager.db;

namespace SaleManager.Controllers
{
    public class OrderController
    {
        IOrderRepository _orderRepository;

        public OrderController()
            : this(new OrderRepository())
        {
        }

        public OrderController(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public Order Create(int saleId)
        {
            return _orderRepository.Create(saleId, CreateOrderNumber());
        }

        public void Complete(int id)
        {
            _orderRepository.Complete(id);
        }

        public double GetTotal(int id)
        {
            return _orderRepository.GetTotal(id);
        }

        public bool HasOpenOrder()
        {
            return _orderRepository.HasOpenOrder();
        }

        public void Cancel()
        {
            _orderRepository.Cancel();
        }

        public List<Order> GetCompletedOrdersBySaleId(int saleId)
        {
            return _orderRepository.GetCompletedOrdersBySaleId(saleId).ToList();
        }

        public Order GetById(int id)
        {
            return _orderRepository.GetById(id);
        }

        public List<Order> GetAll()
        {
            return _orderRepository.GetAll().ToList();
        }

        private string CreateOrderNumber()
        {
            string hr = Convert.ToString(DateTime.Now.Hour.ToString().Length == 2 ? DateTime.Now.Hour.ToString() : "0" + DateTime.Now.Hour.ToString());
            string min = Convert.ToString(DateTime.Now.Minute.ToString().Length == 2 ? DateTime.Now.Minute.ToString() : "0" + DateTime.Now.Minute.ToString());
            string sec = Convert.ToString(DateTime.Now.Second.ToString().Length == 2 ? DateTime.Now.Second.ToString() : "0" + DateTime.Now.Second.ToString());
            string day = Convert.ToString(DateTime.Now.Day.ToString().Length == 2 ? DateTime.Now.Day.ToString() : "0" + DateTime.Now.Day.ToString());
            string month = Convert.ToString(DateTime.Now.Month.ToString().Length == 2 ? DateTime.Now.Month.ToString() : "0" + DateTime.Now.Month.ToString());
            string year = DateTime.Now.Year.ToString();

            return hr + min + sec + "-" + day + month + year;
        }
    }
}
