﻿using Microsoft.AspNetCore.Mvc;
using MiPrimeraAplicacionEnNetCore.Models;
using System.Diagnostics;

namespace MiPrimeraAplicacionEnNetCore.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult MiPagina()
        {
            return View();
        }

        public int numero()
        {
            return 10;
        }

        public string saludo() {
            return "hola amigos como están?";
                }

        public double sueldo()
        {
            return 100.4;
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}