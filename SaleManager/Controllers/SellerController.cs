using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SaleManager.Models.Interfaces;
using SaleManager.Data;
using SaleManager.db;

namespace SaleManager.Controllers
{
    public class SellerController
    {
        ISellerRepository _sellerRepository;

        public SellerController()
            : this(new SellerRepository())
        {
        }

        public SellerController(ISellerRepository sellerRepository)
        {
            _sellerRepository = sellerRepository;
        }

        public List<Seller> GetAll()
        {
            return _sellerRepository.GetAll().ToList();
        }

        public Seller GetById(int id)
        {
            return _sellerRepository.GetById(id);
        }

        public void Add(Seller seller)
        {
            _sellerRepository.Add(seller);
        }

        public void Edit(Seller seller)
        {
            _sellerRepository.Edit(seller);
        }

        public void Remove(int id)
        {
            _sellerRepository.Remove(id);
        }
    }
}
