using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AluguelWeb.Models.Entidades
{
    public class Editora
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        [Required]
        [MinLength(14)]
        [MaxLength(18)]
        public string Cnpj { get; set; }
    }
}
