using EmployeeManagement.Models;
using EmployeeManagement.ViewModels;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Controllers
{
    public class HomeController : Controller
    {
        private IEmployeeRepository _employRepository;
        private readonly IHostingEnvironment hostenv;

        public HomeController(IEmployeeRepository employRepository, IHostingEnvironment hostenv)
        {
            _employRepository = employRepository;
            this.hostenv = hostenv;
        }

        public ViewResult Index()
        {
            var model = _employRepository.GetAllEmployee();
            return View(model);
        }


      
        public ViewResult details(int Id)
        {
            HomeDetailsViewModels homeDetailsViewModels = new HomeDetailsViewModels()
            {
                employee = _employRepository.GetEmployee(Id),
                Details = "Employee Details"
            };
        
   
            return View(homeDetailsViewModels);
        }

       [HttpGet]
       public ViewResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(EmployeeViewModel model)
        {
            if (ModelState.IsValid)
            {
                string uniqueFilename = null;

                if (model.Photo != null)
                {
                    string uploadsFolder = Path.Combine(hostenv.WebRootPath, "images");
                    uniqueFilename = Guid.NewGuid().ToString() + "_" + model.Photo.FileName;
                    string filePath = Path.Combine(uploadsFolder, uniqueFilename);
                    model.Photo.CopyTo(new FileStream(filePath, FileMode.Create));
                }

                Employee newEmployee = new Employee
                {
                    Name = model.Name,
                    Email = model.Email,
                    Departament = model.Departament,
                    PhotoPath = uniqueFilename
                };

                _employRepository.CreateNew(newEmployee);
              
            }
            return View();
        }

    }
}
