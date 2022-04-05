using Microsoft.AspNetCore.Mvc;
using RazorProject.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RazorProject.Controllers
{
    public class StudentController : Controller
    {
        private IRepository _repository;
        public StudentController(IRepository repository)
        {
            _repository = repository;
        }

        public IActionResult Index()
        {
            return View(_repository.GetAll());
        }
    }
}
