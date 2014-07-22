using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SaleManager.db;

namespace SaleManager.Models.Interfaces
{
    public interface ISellerRepository : ICreate<Seller>, IRetrieve<Seller>, IUpdate<Seller>, IDelete<Seller>
    {
    }
}
