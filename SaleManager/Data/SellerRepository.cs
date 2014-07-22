using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SaleManager.Models.Interfaces;
using SaleManager.db;

namespace SaleManager.Data
{
    public class SellerRepository : ISellerRepository
    {
        public IQueryable<Seller> GetAll()
        {
            return Seller.All();
        }

        public Seller GetById(int id)
        {
            return Seller.SingleOrDefault(e => e.id == id);
        }

        public void Add(Seller seller)
        {
            Seller s = new Seller();
            s.name = seller.name;
            s.Save();
        }

        public void Edit(Seller seller)
        {
            Seller s = Seller.SingleOrDefault(e => e.id == seller.id);

            if (s != null)
            {
                s.name = seller.name;
                s.Save();
            }
        }

        public void Remove(int id)
        {
            Seller s = Seller.SingleOrDefault(e => e.id == id);

            if (s != null)
            {
                s.Delete();
            }
        }
    }
}
