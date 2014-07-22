using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SaleManager.Models.Interfaces;
using System.Data;
using SaleManager.Data;
using SaleManager.Models;

namespace SaleManager.Controllers
{
    public class TotalController
    {
        ITotalRepository _totalRepository;

        public TotalController()
            : this(new TotalRepository())
        {
        }

        public TotalController(ITotalRepository totalRepository)
        {
            _totalRepository = totalRepository;
        }

        public List<Total> GetTotalsBySaleId(int id)
        {
            return _totalRepository.GetTotalsBySaleId(id).ToList();
        }
    }
}
