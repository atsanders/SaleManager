using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SaleManager.Models.Interfaces
{
    public interface IRetrieve<T>
    {
        IQueryable<T> GetAll();
        T GetById(int id);
    }
}
