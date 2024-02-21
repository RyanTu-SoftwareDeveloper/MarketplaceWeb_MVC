using MarketplaceWeb.DataAccess.Data;
using MarketplaceWeb.DataAccess.Repository.IRepository;
using MarketplaceWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MarketplaceWeb.DataAccess.Repository
{
    public interface IProductRepository : IRepository<Product>
    {
        void Update(Product obj);
    }

}
