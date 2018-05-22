using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Aula1505.Models
{
    public class Categoria
    {
        public int CategoriaID { get; set; }

        [Display(Name="Título")]
        [Required(ErrorMessage ="Favor preencher o campo Título.")]
        public string Nome { get; set; }
        public bool Ativo { get; set; }

    }
}