using EmployeeManagement.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.ViewModels
{
    public class EmployeeViewModel
    {

        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        public string Email { get; set; }

        public IFormFile Photo { get; set; }

        public Dept Departament { get; set; }
    }
}
