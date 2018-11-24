using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SiteMvc.Models
{
    public class Palavra
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo 'Palavra' é obrigatório!")]
        public string Nome  { get; set; }

        public byte? Nivel { get; set; }
    }
}
