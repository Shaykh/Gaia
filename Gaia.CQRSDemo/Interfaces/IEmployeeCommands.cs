using Gaia.CQRSDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaia.CQRSDemo.Interfaces
{
    public interface IEmployeeCommands
    {
        void SaveEmployeeData(Employee employee);
    }
}
