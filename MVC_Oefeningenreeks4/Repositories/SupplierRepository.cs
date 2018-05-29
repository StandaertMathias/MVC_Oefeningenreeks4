using MVC_Oefeningenreeks4.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Oefeningenreeks4.Repositories
{
    public class SupplierRepository
    {
        private OrderDBContext db;
        public SupplierRepository(OrderDBContext context)
        {
            db = context;
        }
    }
}
