using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Models
{
    public class Employee
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
  
        public string Email { get; set; }

        public string PhotoPath { get; set; }

        public Dept Departament { get; set; }

       
    }
}
