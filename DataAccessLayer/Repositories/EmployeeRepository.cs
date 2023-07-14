using System.Collections.Generic;
using System.Linq;
using DataAccessLayer.Model.Interfaces;
using DataAccessLayer.Model.Models;

namespace DataAccessLayer.Repositories
{ 
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly IDbWrapper<Employee> _employeeDbWrapper;

        public IEnumerable<Employee> GetAll()
        {
            return _employeeDbWrapper.FindAll();
        }
        

        public Employee GetByCodeEmployee(string employeeCode)
        {
            return _employeeDbWrapper.Find(t => t.CompanyCode.Equals(employeeCode))?.FirstOrDefault(); ;
        }


        public  bool SaveEmployeeInformation(Employee employee)
        {
            var itemRepo = _employeeDbWrapper.Find(t => t.SiteId.Equals(employee.SiteId) && t.EmployeeCode.Equals(employee.EmployeeCode))?.FirstOrDefault();

            try
            {
                if (itemRepo != null)
                {
                    itemRepo.SiteId = employee.SiteId;
                    itemRepo.CompanyCode = employee.CompanyCode;
                    itemRepo.EmployeeCode = employee.EmployeeCode;
                    itemRepo.EmployeeName = employee.EmployeeName;
                    itemRepo.Occuption = employee.Occuption;
                    itemRepo.EmployeeStatus = employee.EmployeeStatus;
                    itemRepo.EmailAddress = employee.EmailAddress;
                    itemRepo.Phone = employee.Phone;
                    itemRepo.LastModified = employee.LastModified;
                    return _employeeDbWrapper.Update(itemRepo);
                }

            }
            catch (System.Exception ex)
            {               
                 
            }

            return _employeeDbWrapper.Insert(employee);
        }


    }
}
