using Microsoft.AspNetCore.Mvc;
using RazorProject.Entities;
using RazorProject.Models;
using RazorProject.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RazorProject.Controllers
{
    public class PlayerController : Controller
    {
        private readonly ICalculator _calculator;
        private readonly ICalculator _calculator2;

        public PlayerController(ICalculator calculator, ICalculator calculator2)
        {
            _calculator = calculator;
            _calculator2 = calculator2;
        }

        public IActionResult Info(PlayerViewModel vm)
        {
            return View(vm);
        }
        [HttpGet]
        public IActionResult Add()
        {
            var model = new PlayerViewModel
            {
                Player = new Player()
            };
            model.Player.Score = (double)_calculator.Calculate(100);
            return View(model);
        }
        [HttpPost]
        public IActionResult Add(Player player)
        {
            //with problem
            return RedirectToAction("Info", "Player", new PlayerViewModel { Player = player }) ;
        }

    }
}
