using Gaia.CQRSDemo.Interfaces;
using Gaia.CQRSDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaia.CQRSDemo.Repositories
{
    public class EmployeeCommandsRepository : IEmployeeCommandsRepository
    {
        public void SaveEmployee(Employee employee)
        {
            throw new NotImplementedException();
        }
    }
}
