using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using RazorProject.Entities;
using RazorProject.FakeRepo;
using RazorProject.Helpers;
using RazorProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RazorProject.Controllers
{
    
    public class HomeController : Controller
    {
        private readonly IWebHostEnvironment _webhost;

        public HomeController(IWebHostEnvironment webhost)
        {
            _webhost = webhost;
        }

        public IActionResult Index(bool hr=false)
        {
            ViewData["HR"] = hr; //ViewBag . ViewDat TempData
            var model = new PersonListViewModel
            {
                Persons = PersonRepo.Persons
            };
            return View(model);
        }
         [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Register(PersonViewModel model)
        {
            var helper = new ImageHelper(_webhost);
            model.Person.ImageUrl = await helper.SaveFile(model.File);
            PersonRepo.Persons.Add(model.Person);
            return RedirectToAction("Index",new { hr = true });
        }
        public JsonResult Index2(string key)
        {
            List<Player> model = new List<Player>
            {
                new Player{Id=1,Name="John",Score=40},
                new Player{Id=2,Name="Rafiq",Score=80},
                new Player{Id=3,Name="Leyla",Score=75},
                new Player{Id=3,Name="Akif",Score=100}
            };
            if (string.IsNullOrEmpty(key))
            {
                return Json(model);
            }
            var result = model.Where(x => x.Name.ToLower().Contains(key)).ToList();

            return Json(result);
        }
        public JsonResult Index3(string key, double score)
        {
            List<Player> model = new List<Player>
            {
                new Player{Id=1,Name="John",Score=40},
                new Player{Id=2,Name="Rafiq",Score=80},
                new Player{Id=3,Name="Leyla",Score=75},
                new Player{Id=3,Name="Akif",Score=100}
            };
            if (string.IsNullOrEmpty(key))
            {
                return Json(model);
            }
            var result = model.Where(x => x.Name.ToLower().Contains(key) && x.Score <= score).ToList();

            return Json(result);
        }

        public IActionResult PlayerForm()
        {
            return View();
        }
        public IActionResult Index5(int id)
        {
            return Json(id);
        }
        public IActionResult Index6(int id,int id2)
        {
            return Json(id.ToString()+" "+id2.ToString());
        }

    }
}
