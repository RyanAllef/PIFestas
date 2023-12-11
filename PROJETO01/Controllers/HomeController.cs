﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PROJETO01.Dados.EntityFramework;
using PROJETO01.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace PROJETO01.Controllers
{
    public class HomeController : Controller
    {
        //private readonly ILogger<HomeController> _logger;

        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger;
        //}

        public IActionResult Index()
        {
            var listaDeFestas = new Contexto().CadastroFesta.ToList();

            return View(listaDeFestas);
        }
        public IActionResult LoginButton()
        {
            return RedirectToAction("Listar");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
