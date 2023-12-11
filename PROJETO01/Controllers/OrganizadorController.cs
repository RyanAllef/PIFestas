using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PROJETO01.Dados.EntityFramework;
using PROJETO01.Modelos;

namespace Party51.Controllers
{
    public class OrganizadorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Adicionar()
        {
            return View("Adicionar");
        }

        public IActionResult AdicionarConfirmacao(Organizador entidade)
        {
            var db = new Contexto();

            var obj = db.Organizador.FirstOrDefault(f => f.OrganizadorID == entidade.OrganizadorID);

            if (obj == null)
            {
                db.Organizador.Add(entidade);
            }
            else
            {
                obj.Nome = entidade.Nome;
                db.Organizador.Update(obj);
            }

            db.SaveChanges();

            return RedirectToAction("Listar");
        }

        [HttpGet]
        public IActionResult Editar(int OrganizadorID)
        {
            var db = new Contexto();
            var entidade = db.Organizador.First(item => item.OrganizadorID == OrganizadorID);
            



            return View("Adicionar", entidade);
        }

        public IActionResult Listar()
        {

            //SELECT * FROM Estado
            var listaDeOrganizadores = new Contexto().Organizador.ToList();

            return View(listaDeOrganizadores);
        }

        public IActionResult Excluir(int OrganizadorID)
        {
            var db = new Contexto();
            var entidade = db.Organizador.First(item => item.OrganizadorID == OrganizadorID);
            db.Organizador.Remove(entidade);
            db.SaveChanges();

            return RedirectToAction("Listar");


        }
    }
}