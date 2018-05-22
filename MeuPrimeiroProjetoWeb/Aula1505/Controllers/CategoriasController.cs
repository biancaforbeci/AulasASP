using Aula1505.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Aula1505.Controllers
{
    public class CategoriasController : Controller
    {
        // GET: Categorias
        public ActionResult Index()
        {
            List<Categoria> categorias = new List<Categoria>();

            categorias.Add(
                new Categoria
                {
                    Nome = "Casa"
                }
                );

            categorias.Add(new Categoria() { Nome = "Trabalho" });
            categorias.Add(new Categoria() { Nome = "Família" });
            categorias.Add(new Categoria() { Nome = "Carro" });

            ViewBag.MinhasCategorias = categorias;

            return View();
        }

        public ActionResult Index2()
        {
            List<Categoria> categorias = new List<Categoria>();

            categorias.Add(
                new Categoria
                {
                    Nome = "Casa"
                }
                );

            categorias.Add(new Categoria() { Nome = "Trabalho" });
            categorias.Add(new Categoria() { Nome = "Família" });
            categorias.Add(new Categoria() { Nome = "Carro" });


            return View();
        }

        public ActionResult Formulario()   //GET - ao chamar página
        {
            return View();
        }

        [HttpPost]
        public ActionResult Formulario(string nome, string descricao, bool ativo)  //POST ao clicar em algum botão
        {
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Categoria categoria)
        {
            if (ModelState.IsValid)
            {
                //salvar no banco
            }


            return View(categoria);
        }

    }
}