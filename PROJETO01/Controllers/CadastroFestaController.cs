using Microsoft.AspNetCore.Mvc;
using PROJETO01.Dados.EntityFramework;
using PROJETO01.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PROJETO01.Controllers
{
    public class CadastroFestaController : Controller
    {


        [HttpGet]
        public IActionResult Adicionar()
        {
            var dbOrganizador = new Contexto();
            ViewBag.Organizador = dbOrganizador.Organizador.ToList();
            var dbEstado = new Contexto();
           ViewBag.Estado = dbEstado.Estado.ToList();
                


            return View("AdicionarFesta");
            
            


        }

        public IActionResult AdicionarConfirmacao(CadastroFesta entidade)
        {
            var db = new Contexto();

            var obj = db.CadastroFesta.FirstOrDefault(f => f.FestaID == entidade.FestaID);

            if (obj == null)
            {
                db.CadastroFesta.Add(entidade);
            }
            else
            {
                obj.Nome = entidade.Nome;
                db.CadastroFesta.Update(obj);
            }

            db.SaveChanges();

            return RedirectToAction("Listar");
        }

        [HttpGet]
        public IActionResult Editar(int FestaID)
        {
            var db = new Contexto();
            var entidade = db.CadastroFesta.First(item => item.FestaID == FestaID);
            var dbOrganizador = new Contexto();
            ViewBag.Organizador = dbOrganizador.Organizador.ToList();
            var dbEstado = new Contexto();
            ViewBag.Estado = dbEstado.Estado.ToList();

            return View("AdicionarFesta", entidade);
        }

        public IActionResult Listar()
        {

            //SELECT * FROM Estado
            var listaDeFestas = new Contexto().CadastroFesta.ToList();

            return View(listaDeFestas);
        }

        public IActionResult Excluir(int FestaID)
        {
            var db = new Contexto();
            var entidade = db.CadastroFesta.First(f => f.FestaID == FestaID);
            db.CadastroFesta.Remove(entidade);
            db.SaveChanges();

            return RedirectToAction("Listar");


        }
    }
}
