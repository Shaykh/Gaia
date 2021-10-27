using Gaia.CQRSDemo.Interfaces;
using Gaia.CQRSDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaia.CQRSDemo.Repositories
{
    public class EmployeeQueriesRepository : IEmployeeQueriesRepository
    {
        public Employee GetByID(int employeeID)
        {
            return new Employee()
            {
                Id = 100,
                FirstName = "Cheick",
                LastName = "Smith",
                DateOfBirth = new DateTime(1978, 6, 5),
                Address = "11 rue de la légende",
                City = "Lyon",
                PostalCode = "69000"
            };
        }
    }
}
