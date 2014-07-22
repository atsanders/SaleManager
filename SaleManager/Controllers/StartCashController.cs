using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SaleManager.Models.Interfaces;
using SaleManager.db;
using SaleManager.Data;

namespace SaleManager.Controllers
{
    public class StartCashController
    {
        IStartCashRepository _startCashRepository;

        public StartCashController()
            : this(new StartCashRepository())
        {
        }

        public StartCashController(IStartCashRepository startCashRepository)
        {
            _startCashRepository = startCashRepository;
        }

        public List<StartCash> GetAllBySaleId(int id)
        {
            return _startCashRepository.GetAllBySaleId(id);
        }

        public StartCash GetById(int id)
        {
            return _startCashRepository.GetById(id);
        }

        public void Add(StartCash startCash)
        {
            _startCashRepository.Add(startCash);
        }

        public void Edit(StartCash startCash)
        {
            _startCashRepository.Edit(startCash);
        }

        public void Remove(int id)
        {
            _startCashRepository.Remove(id);
        }
    }
}
