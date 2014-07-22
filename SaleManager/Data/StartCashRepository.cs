using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SaleManager.db;
using SaleManager.Models.Interfaces;

namespace SaleManager.Data
{
    public class StartCashRepository : IStartCashRepository
    {
        public List<StartCash> GetAllBySaleId(int id)
        {
            var startingCash = (from sc in db.StartCash.All()
                                join si in Seller.All() on sc.sellerId equals si.id
                                where sc.saleId == id
                                orderby si.name
                                select new StartCash()
                                {
                                    id = sc.id,
                                    cashAmount = sc.cashAmount,
                                    saleId = sc.saleId,
                                    sellerId = sc.sellerId,
                                    SellerName = si.name
                                }).ToList();

            return startingCash;
        }

        public IQueryable<StartCash> GetAll()
        {
            return db.StartCash.All();
        }

        public StartCash GetById(int id)
        {
            return db.StartCash.SingleOrDefault(e => e.id == id);
        }

        public void Add(StartCash startCash)
        {
            StartCash sc = new StartCash();
            sc.sellerId = startCash.sellerId;
            sc.saleId = startCash.saleId;
            sc.cashAmount = startCash.cashAmount;
            sc.Save();
        }

        public void Edit(StartCash startCash)
        {
            StartCash sc = StartCash.SingleOrDefault(e => e.id == startCash.id);

            if (sc != null)
            {
                sc.sellerId = startCash.sellerId;
                sc.cashAmount = startCash.cashAmount;
                sc.Save();
            }
        }

        public void Remove(int id)
        {
            StartCash sc = StartCash.SingleOrDefault(e => e.id == id);

            if (sc != null)
            {
                sc.Delete();
            }
        }
    }
}
