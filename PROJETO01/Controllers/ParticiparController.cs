using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PROJETO01.Dados.EntityFramework;
using PROJETO01.Modelos;
using System;
using System.Linq;

namespace PROJETO01.Controllers
{
    public class ParticiparController : Controller
    {

        [HttpGet]
        public IActionResult Participantes(int festaId, int ConviteID)
        {
            var usuarioId = HttpContext.Session.GetInt32("UsuarioID").GetValueOrDefault(0);

            if (usuarioId == 0)
                return RedirectToAction("Index", "Login");

            var dbCadastroFesta = new Contexto();
            Participantes participantes = new Participantes();
            participantes.FestaID = festaId;
            participantes.UsuarioID = usuarioId;
            participantes.ConviteID = ConviteID;


            try {
                dbCadastroFesta.Participantes.Add(participantes);
                dbCadastroFesta.SaveChanges();
            }catch (Exception ex)
            {
                if (ex.Message == "An error occurred while updating the entries. See the inner exception for details.")
                {
                    ViewBag.ErroParticipar = "Uhuul! Você já está participando dessa festa!!";
                }
                else
                {
                    ViewBag.ErroParticipar = ex.Message;
                }
                //return RedirectToAction("Index", "Home");

            }


            ViewBag.CadastroFesta = dbCadastroFesta.CadastroFesta.ToList();
            var dbLogin = new Contexto();
            ViewBag.Login = dbLogin.Login.ToList();

            return RedirectToAction("Listar");

        }

        public IActionResult Listar()
        {
            var contexto = new Contexto();
            var listarParticipante = contexto
                .Participantes
                .Include("Usuario")
                .Include("NomeFesta")
                .ToList();

            return View(listarParticipante);
        }
    }
}