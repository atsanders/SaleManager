using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SaleManager.Models.Interfaces;
using SaleManager.Data;
using SaleManager.db;

namespace SaleManager.Controllers
{
    public class SaleController
    {
        ISaleRepository _saleRepository;

        public SaleController()
            : this(new SaleRepository())
        {
        }

        public SaleController(ISaleRepository saleRepository)
        {
            _saleRepository = saleRepository;
        }

        public List<Sale> GetAll()
        {
            return _saleRepository.GetAll().ToList();
        }

        public Sale GetById(int id)
        {
            return _saleRepository.GetById(id);
        }

        public Sale GetOpenSale()
        {
            return _saleRepository.GetOpenSale();
        }

        public bool IsOpen
        {
            get
            {
                return _saleRepository.IsOpen;
            }
        }

        public void Open()
        {
            _saleRepository.Open();
        }

        public void Close()
        {
            _saleRepository.Close();
        }
    }
}
