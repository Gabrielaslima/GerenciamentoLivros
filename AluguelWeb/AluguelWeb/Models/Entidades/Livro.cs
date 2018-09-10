using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AluguelWeb.Models.Entidades
{
    public class Livro
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int AutorID { get; set; }
        public Autor Autor { get; set; }
        public int EditoraID { get; set; }
        public Editora Editora { get; set; }
        public StatusLivro Status { get; set; }
    }
}
