using Gaia.CQRSDemo.DTOs;
using Gaia.CQRSDemo.Interfaces;
using Gaia.CQRSDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaia.CQRSDemo.Queries
{
    public class EmployeeQueries : IEmployeeQueries
    {
        private readonly IEmployeeQueriesRepository _repository;
        public EmployeeQueries(IEmployeeQueriesRepository repository)
        {
            _repository = repository;
        }
        public EmployeeDTO FindByID(int employeeID)
        {
            var employee = _repository.GetByID(employeeID);
            return new EmployeeDTO
            {
                Id = employee.Id,
                FullName = $"{employee.FirstName} {employee.LastName}",
                CompleteAdress = $"{employee.Address}, {employee.PostalCode} {employee.City}",
                Age = DateTime.Now.Year - employee.DateOfBirth.Year
            };
        }
    }
}
