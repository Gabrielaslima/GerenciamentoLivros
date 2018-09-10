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
    public class ClienteController : Controller
    {
        private readonly AluguelContexto aluguelContexto;

        public ClienteController(AluguelContexto aluguelContexto)
        {
            this.aluguelContexto = aluguelContexto;
        }

        [HttpGet]
        [Route("Cliente")]
        public IActionResult Cliente()
        {
            var clientes = aluguelContexto.Clientes.ToList();

            return View(clientes);
        }

        [HttpGet]
        [Route("CadastroCliente")]
        public ActionResult CadastroCliente()
        {
            return View();
        }

        [HttpPost]
        [Route("CadastrarCliente")]
        public IActionResult CadastrarCliente([FromForm] Cliente cliente)
        {
            var index = new { id = cliente.Id + 1 };

            aluguelContexto.Add(cliente);

            aluguelContexto.SaveChanges();

            return RedirectToAction(nameof(Cliente));
        }

        [HttpGet]
        [Route("{id}/EdicaoCliente")]
        public ActionResult EdicaoCliente(int id)
        {
            return View("EditarCliente", aluguelContexto.Clientes.FirstOrDefault(x => x.Id == id));
        }

        [HttpPost]
        [Route("{id}/editarCliente")]
        public IActionResult EditarCliente([FromForm] Cliente cliente, int id)
        {
            cliente.Id = id;

            aluguelContexto.Update(cliente);

            aluguelContexto.SaveChanges();

            return RedirectToAction(nameof(Cliente));
        }

        [HttpGet()]
        [Route("deletarCliente/{id}")]
        public IActionResult DeletarCliente(int id)
        {
            aluguelContexto.Remove(aluguelContexto.Clientes.Find(id));

            aluguelContexto.SaveChanges();

            return RedirectToAction(nameof(Cliente));
        }

        [HttpGet()]
        [Route("detalhesCliente/{id}")]
        public IActionResult DetalhesCliente(int id)
        {
            var cliente = aluguelContexto.Clientes.FirstOrDefault(x => x.Id == id);

            return View("DetalhesCliente", cliente);
        }
    }
}