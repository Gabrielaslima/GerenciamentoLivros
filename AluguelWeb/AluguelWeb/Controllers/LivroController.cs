using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using AluguelWeb.Contexto;
using AluguelWeb.Models.Entidades;
using Microsoft.AspNetCore.Mvc;

namespace AluguelWeb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LivroController : Controller
    {

        private readonly AluguelContexto aluguelContexto;

        public LivroController(AluguelContexto aluguelContexto)
        {
            this.aluguelContexto = aluguelContexto;
        }

        [HttpGet]
        [Route("Livro")]
        public ActionResult Livro()
        {
            //var livros = aluguelContexto.Livros.ToList();

            //return View(livros);

            return View(aluguelContexto.Livros.ToList());
        }

        [HttpGet]
        [Route("CadastroLivro")]
        public ActionResult CadastroLivro()
        {
            return View();
        }

        [HttpGet()]
        [Route("detalhesLivro/{id}")]
        public IActionResult DetalhesLivro(int id)
        {
            var livro = aluguelContexto.Livros.FirstOrDefault(x => x.Id == id);

            return View("DetalhesLivro", livro);
        }

        [HttpPost]
        [Route("CadastrarLivro")]
        public ActionResult CadastrarLivro([FromForm] Livro livro)
        {
            var id = new { id = livro.Id + 1 };

            livro.Status = StatusLivro.Disponivel;

            aluguelContexto.Add(livro);

            aluguelContexto.SaveChanges();

            return RedirectToAction(nameof(Livro));
        }

        [HttpGet()]
        [Route("deletarLivro/{id}")]
        public IActionResult DeletarLivro(int id)
        {

            aluguelContexto.Remove(aluguelContexto.Livros.Find(id));

            aluguelContexto.SaveChanges();

            return RedirectToAction(nameof(Livro));
        }

        [HttpGet]
        [Route("{id}/EdicaoLivro")]
        public ActionResult EdicaoLivro(int id)
        {
            return View("EditarLivro", aluguelContexto.Livros.FirstOrDefault(x => x.Id == id));
        }

        [HttpPost]
        [Route("{id}/editarLivro")]
        public IActionResult EditarLivro([FromForm] Livro livro, int id)
        {
            livro.Id = id;

            aluguelContexto.Update(livro);

            aluguelContexto.SaveChanges();

            return RedirectToAction(nameof(Livro));
        }
            
    }
}