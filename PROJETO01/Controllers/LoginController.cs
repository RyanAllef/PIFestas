using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.WebEncoders.Testing;
using PROJETO01.Dados.EntityFramework;
using PROJETO01.Modelos;
using PROJETO01.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace PROJETO01.Controllers
{
    public class LoginController : Controller
    {
        private readonly ILogger<LoginController> _logger;

        public LoginController(ILogger<LoginController> logger)
        {
            _logger = logger;
        }

        public IActionResult ErroLogin()
        {
            var listaDeFestas = new Contexto().Login.ToList();

            return View(listaDeFestas);
        }
        public IActionResult LoginButton()
        {
            return RedirectToAction("");
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpPost]
        public IActionResult IndexConfirm(Login Autenticacao)
        {
            var contexto = new Contexto();

            var usuarioAutenticado = contexto.Login
                .Where(Login => Login.Nome == Autenticacao.Nome && Login.Senha == Autenticacao.Senha)
                .FirstOrDefault();

            if (usuarioAutenticado != null)
            {
                HttpContext.Session.SetInt32("UsuarioID", usuarioAutenticado.UsuarioID);
                return RedirectToAction("Index","Home");
            }
            else
            {
                TempData["ErroLogin"] = "Usuário ou senha incorretos";
                return RedirectToAction("Index");
            }
        }

        public IActionResult Index()
        {
            var listaDeFestas = new Contexto().Login.ToList();

            if (TempData.ContainsKey("ErroLogin"))
            {
                ViewBag.ErroLogin = TempData["ErroLogin"];
            }

            return View(listaDeFestas);
        }

    }


}
