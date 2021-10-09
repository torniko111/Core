using EmployeeManagement.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Models
{
    public class EmployeeRepoServerSide : IEmployeeRepository
    {
        private readonly KunvekatDbContext context;

        public EmployeeRepoServerSide(KunvekatDbContext context)
        {
            this.context = context;
        }
        public Employee CreateNew(Employee employee)
        {
            context.employees.Add(employee);
            context.SaveChanges();
            return employee;
        }

        public Employee Delete(int id)
        {
            Employee employee = context.employees.Find(id);
            if(employee != null)
            {
                context.employees.Remove(employee);
                context.SaveChanges();
            }
            return employee;
        }

        public IEnumerable<Employee> GetAllEmployee()
        {
            return context.employees;
        }

        public Employee GetEmployee(int id)
        {
            return context.employees.Find(id);
        }

        public Employee Update(Employee employeeChanges)
        {
            var employee = context.Attach(employeeChanges);
            employee.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
            return employeeChanges;
        }
    }
}
