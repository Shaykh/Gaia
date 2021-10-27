using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaia.CQRSDemo.DTOs
{
    public class EmployeeDTO
    {
        public int Id { get; set; }
        public int Age { get; set; }
        public string FullName { get; set; }
        public string CompleteAdress { get; set; }
    }
}
