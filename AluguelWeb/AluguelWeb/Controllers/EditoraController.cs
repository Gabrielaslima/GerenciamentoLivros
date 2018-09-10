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
    public class EditoraController : Controller
    {
        private readonly AluguelContexto aluguelContexto;

        public EditoraController(AluguelContexto aluguelContexto)
        {
            this.aluguelContexto = aluguelContexto;
        }

        [HttpGet]
        [Route("Editora")]
        public IActionResult Editora()
        {
            var editoras = aluguelContexto.Editoras.ToList();

            return View(editoras);
        }

        [HttpGet]
        [Route("CadastroEditora")]
        public ActionResult CadastroEditora()
        {
            return View();
        }

        [HttpPost]
        [Route("CadastrarEditora")]
        public IActionResult CadastrarEditora([FromForm] Editora editora)
        {
            var index = new { id = editora.Id + 1 };

            aluguelContexto.Add(editora);

            aluguelContexto.SaveChanges();

            return RedirectToAction(nameof(Editora));
        }

        [HttpGet]
        [Route("{id}/EdicaoEditora")]
        public ActionResult EdicaoEditora(int id)
        {
            return View("EditarEditora", aluguelContexto.Editoras.FirstOrDefault(x => x.Id == id));
        }

        [HttpPost]
        [Route("{id}/editarEditora")]
        public IActionResult EditarEditora([FromForm] Editora editora, int id)
        {
            editora.Id = id;

            aluguelContexto.Update(editora);

            aluguelContexto.SaveChanges();

            return RedirectToAction(nameof(Editora));
        }

        [HttpGet()]
        [Route("deletarEditora/{id}")]
        public IActionResult DeletarEditora(int id)
        {

            aluguelContexto.Remove(aluguelContexto.Editoras.Find(id));

            aluguelContexto.SaveChanges();

            return RedirectToAction(nameof(Editora));
        }

        [HttpGet()]
        [Route("detalhesEditora/{id}")]
        public IActionResult DetalhesEditora(int id)
        {
            var editora = aluguelContexto.Editoras.FirstOrDefault(x => x.Id == id);

            return View("DetalhesEditora", editora);
        }
    }
}