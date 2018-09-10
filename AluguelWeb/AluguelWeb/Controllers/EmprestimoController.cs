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
    public class EmprestimoController : Controller
    {
        private readonly AluguelContexto aluguelContexto;

        public EmprestimoController(AluguelContexto aluguelContexto)
        {
            this.aluguelContexto = aluguelContexto;
        }

        [HttpGet]
        [Route("Emprestimo")]
        public ActionResult Emprestimo()
        {
            return View(aluguelContexto.Emprestimos.ToList());
        }

        [HttpGet]
        [Route("CadastroEmprestimo")]
        public ActionResult CadastroEmprestimo()
        {
            return View();
        }

        [HttpGet()]
        [Route("detalhesEmprestimo/{id}")]
        public IActionResult DetalhesEmprestimo(int id)
        {
            var emprestimo = aluguelContexto.Emprestimos.FirstOrDefault(x => x.Id == id);

            return View("DetalhesEmprestimo", emprestimo);
        }

        [HttpPost]
        [Route("CadastrarEmprestimo")]
        public ActionResult CadastrarEmprestimo([FromForm] Emprestimo emprestimo)
        {
            var id = new { id = emprestimo.Id + 1 };

            var idLivro = emprestimo.LivroID;

            var livro = aluguelContexto.Livros.FirstOrDefault(x => x.Id == idLivro);

            livro.Status = StatusLivro.Indisponivel;

            emprestimo.DataEmprestimo = DateTime.Now;

            var data = DateTime.Now;

            emprestimo.PreviaDevolucao = data.AddDays(30);

            aluguelContexto.Add(emprestimo);

            aluguelContexto.SaveChanges();

            return RedirectToAction(nameof(Emprestimo));
        }

        [HttpGet()]
        [Route("deletarEmprestimo/{id}")]
        public IActionResult DeletarEmprestimo(int id)
        {

            aluguelContexto.Remove(aluguelContexto.Emprestimos.Find(id));

            aluguelContexto.SaveChanges();

            return RedirectToAction(nameof(Emprestimo));
        }

        [HttpGet]
        [Route("{id}/EdicaoEmprestimo")]
        public ActionResult EdicaoEmprestimo(int id)
        {
            return View("EditarEmprestimo", aluguelContexto.Emprestimos.FirstOrDefault(x => x.Id == id));
        }

        [HttpPost]
        [Route("{id}/editarEmprestimo")]
        public IActionResult EditarEmprestimo([FromForm] Emprestimo emprestimo, int id)
        {
            emprestimo.Id = id;

            aluguelContexto.Update(emprestimo);

            aluguelContexto.SaveChanges();

            return RedirectToAction(nameof(Emprestimo));
        }
    }
}
