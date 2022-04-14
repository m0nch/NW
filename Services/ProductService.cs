using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    internal class ProductService : BaseService<Product>, IProductService
    {
        private readonly NorthwindEntities _context;
        public ProductService(NorthwindEntities context) :base(context)
        {
            _context = context;
        }
    }
}
