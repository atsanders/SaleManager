using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SaleManager.Models;
using SaleManager.db;
using SubSonic.Query;
using System.Data.SqlClient;
using System.Data;
using SaleManager.Models.Interfaces;
using System.Collections;

namespace SaleManager.Data
{
    public class TotalRepository : ITotalRepository
    {
        public IQueryable<Total> GetTotalsBySaleId(int saleId)
        {
            var saleTotal = (from s in Sale.All()
                             join o in Order.All() on s.id equals o.saleId
                             join oi in OrderItem.All() on o.id equals oi.orderId
                             join se in Seller.All() on oi.sellerId equals se.id
                             where s.endDate == null && o.complete == 1
                             group oi by se.id into g
                             select new 
                             {
                                 SaleTotal = g.Sum(e=>e.price),
                                 SellerId = g.Key
                             }).ToList();

            var contributeTotal = (from s in Sale.All()
                                   join sc in StartCash.All() on s.id equals sc.saleId
                                   join se in Seller.All() on sc.sellerId equals se.id
                                   where s.endDate == null
                                   group sc by se.id into g
                                   select new
                                   {
                                       ContributeTotal = g.Sum(e=>e.cashAmount),
                                       SellerId = g.Key
                                   }).ToList();

            var sellers = (from se in Seller.All()
                           select se).ToList();

            var total = (from se in sellers
                         join st in saleTotal on se.id equals st.SellerId into h
                         from st in h.DefaultIfEmpty()
                         join sc in contributeTotal on se.id equals sc.SellerId into g
                         from sc in g.DefaultIfEmpty()
                         let a = GetSellerName((int)se.id)
                         orderby se.name ascending
                         select new Total()
                         {
                             name = a,
                             startingContribution = sc == null ? 0 : sc.ContributeTotal,
                             saleTotal = st == null ? 0 : st.SaleTotal,
                             total = (sc == null ? 0 : sc.ContributeTotal) + (st == null ? 0 : st.SaleTotal)
                         });

            return total.AsQueryable();
        }

        private string GetSellerName(int id)
        {
            return Seller.SingleOrDefault(e => e.id == id).name;
        }
    }
}