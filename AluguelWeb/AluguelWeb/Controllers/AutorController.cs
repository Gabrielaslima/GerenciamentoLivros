using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AluguelWeb.Contexto;
using AluguelWeb.Models.Entidades;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AluguelWeb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AutorController : Controller
    {
        private readonly AluguelContexto aluguelContexto;

        public AutorController(AluguelContexto aluguelContexto)
        {
            this.aluguelContexto = aluguelContexto;
        }

        [HttpGet]
        [Route("Autor")]
        public IActionResult Autor()
        {
            var autores = aluguelContexto.Autores.ToList();

            return View(autores);
        }

        [HttpGet]
        [Route("CadastroAutor")]
        public ActionResult CadastroAutor()
        {
            return View();
        }

        [HttpPost]
        [Route("CadastrarAutor")]
        public IActionResult CadastrarAutor([FromForm] Autor autor)
        {
            var id = new { id = autor.Id + 1 };

            aluguelContexto.Add(autor);

            aluguelContexto.SaveChanges();

            return RedirectToAction(nameof(Autor));
        }

        [HttpGet]
        [Route("{id}/EdicaoAutor")]
        public ActionResult EdicaoAutor(int id)
        {
            return View("EditarAutor", aluguelContexto.Autores.FirstOrDefault(x => x.Id == id));
        }

        [HttpPost]
        [Route("{id}/editarAutor")]
        public IActionResult EditarAutor([FromForm] Autor autor, int id)
        {
            autor.Id = id;

            aluguelContexto.Update(autor);

            aluguelContexto.SaveChanges();

            return RedirectToAction(nameof(Autor));
        }

        [HttpGet()]
        [Route("deletarAutor/{id}")]
        public IActionResult DeletarAutor(int id)
        {

            aluguelContexto.Remove(aluguelContexto.Autores.Find(id));

            aluguelContexto.SaveChanges();

            return RedirectToAction(nameof(Autor));
        }

        [HttpGet()]
        [Route("detalhesAutor/{id}")]
        public IActionResult DetalhesAutor(int id)
        {
            var autor = aluguelContexto.Autores.FirstOrDefault(x => x.Id == id);

            return View("DetalhesAutor", autor);
        }

    }
}