using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SaleManager.Models.Interfaces;
using SaleManager.db;

namespace SaleManager.Data
{
    public class SaleRepository : ISaleRepository
    {
        public IQueryable<Sale> GetAll()
        {
            return db.Sale.All();
        }

        public bool IsOpen
        {
            get
            {
                Sale sale = db.Sale.SingleOrDefault(e => e.endDate == null);

                return sale != null;
            }
        }

        public Sale GetById(int id)
        {
            return db.Sale.SingleOrDefault(e => e.id == id);
        }

        public Sale GetOpenSale()
        {
            return db.Sale.SingleOrDefault(e => e.endDate == null);
        }

        public void Open()
        {
            Sale sale = new Sale();
            sale.startDate = DateTime.Now.ToString();
            sale.Save();
        }

        public void Close()
        {
            Sale sale = db.Sale.SingleOrDefault(e => e.endDate == null);
            sale.endDate = DateTime.Now.ToString();
            sale.Save();
        }
    }
}
