using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;

namespace Services
{
    internal class CustomerService : BaseService<Customer>, ICustomerService 
    {
        private readonly NorthwindEntities _context;
        public CustomerService(NorthwindEntities context) :base(context)
        {
            _context = context;
        }
    }
}
