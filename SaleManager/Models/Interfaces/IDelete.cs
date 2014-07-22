using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SaleManager.Models.Interfaces
{
    public interface IDelete<T>
    {
        void Remove(int id);
    }
}
