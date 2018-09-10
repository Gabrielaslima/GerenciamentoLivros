using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AluguelWeb.Models.Entidades
{
    public class Autor
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        [Required]
        [MinLength(11)]
        [MaxLength(14)]
        public string Cpf { get; set; }
    }
}
