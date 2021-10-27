using Gaia.CQRSDemo.Interfaces;
using Gaia.CQRSDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaia.CQRSDemo.Commands
{
    public class EmployeeCommands : IEmployeeCommands
    {
        private readonly IEmployeeCommandsRepository _repository;

        public EmployeeCommands(IEmployeeCommandsRepository repository)
        {
            _repository = repository;
        }

        public void SaveEmployeeData(Employee employee)
        {
            
        }
    }
}
