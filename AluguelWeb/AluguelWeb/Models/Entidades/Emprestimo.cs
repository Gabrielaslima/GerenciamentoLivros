using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AluguelWeb.Models.Entidades
{
    public class Emprestimo
    {
        public int Id { get; set; }
        public int LivroID { get; set; }
        public Livro Livro { get; set; }
        public int ClienteID { get; set; }
        public Cliente Cliente { get; set; }
        public DateTime DataEmprestimo { get; set; }
        public DateTime PreviaDevolucao { get; set; }
    }
}
