using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    internal class EmployeeService : BaseService<Employee>, IEmployeeService
    {
        private readonly NorthwindEntities _context;

        public EmployeeService(NorthwindEntities context) :base(context)
        {
            _context = context;
        }
    }
}
