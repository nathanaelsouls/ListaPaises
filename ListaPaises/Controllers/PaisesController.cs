using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using ListaPaises.Models;
using Microsoft.AspNetCore.Mvc;

namespace ListaPaises.Controllers
{
    public class PaisesController : Controller
    {
        private readonly AplicacaoContext _context;

        public PaisesController(AplicacaoContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            List<Pais> listaPaises = new List<Pais>();

            //-----pega dados da tabel
            listaPaises = (from pais in _context.Paises
                           select pais).ToList();

            //-----Inserir um item na lista
            listaPaises.Insert(0, new Pais { Id = 0, Nome = "Selecione" });
            ViewBag.ListaPaises = listaPaises;
            return View();
        }

        [HttpPost]
        public IActionResult Index(Pais pais)
        {
            if(pais.Id == 0)
            {
                ModelState.AddModelError("", "Selecione um país");
            }

            ViewBag.ValorSelecionado = pais.Id;

            List<Pais> listaPaises = new List<Pais>();

            //-----pega dados da tabel
            listaPaises = (from p in _context.Paises
                           select pais).ToList();

            //-----Inserir um item na lista
            listaPaises.Insert(0, new Pais { Id = 0, Nome = "Selecione" });
            ViewBag.ListaPaises = listaPaises;
            return View();
        }
    }
}
