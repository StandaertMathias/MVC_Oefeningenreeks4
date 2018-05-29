using MVC_Oefeningenreeks4.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Oefeningenreeks4.Repositories
{
    public class ProductRepository
    {
        private OrderDBContext db;
        public ProductRepository(OrderDBContext context)
        {
            db = context;
        }

        internal List<Product> GetAllProducts()
        {
            return db.Product
                .Select(p => p)
                .ToList();
        }
        private Supplier GetSupplier(int id)
        {
            return db.Supplier.FirstOrDefault(s => s.Id == id);
        }
    }
}
