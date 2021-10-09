using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Models
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private List<Employee> _employeeList;

        public EmployeeRepository()
        {
            _employeeList = new List<Employee>()
            {
                new Employee() {Id = 1, Name = "mary", Departament =Dept.hr, Email="tornike@gmail.com" },
                new Employee() {Id = 2, Name = "jhon", Departament =Dept.it, Email="tornike@gmail.com" },
                new Employee() {Id = 3, Name = "gela", Departament =Dept.Payroll, Email="tornike@gmail.com" },
            };
        }

        public Employee CreateNew(Employee employee)
        {
            employee.Id = _employeeList.Max(e => e.Id + 1);
            _employeeList.Add(employee);
            return employee;
        }

        public Employee Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Employee> GetAllEmployee()
        {
            return _employeeList;
        }

        public Employee GetEmployee(int Id)
        {
            return _employeeList.FirstOrDefault(e => e.Id == Id);
        }

        public Employee Update(Employee employee)
        {
            throw new NotImplementedException();
        }
    }
}
