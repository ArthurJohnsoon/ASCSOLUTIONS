using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace Projeto.Presentation.Models
{
    public class AlunoViewsModel
    {
        [MinLength(3, ErrorMessage ="Insira no mínimo um nome com {1} caracteres.")]
        [MaxLength(50,ErrorMessage = "Insira no máximo um nome com  {1} caracteres.")]
        [Required(ErrorMessage ="Insira um nome.")]
        public string Nome { get; set; }
        
        [Required(ErrorMessage = "Insira sua matricula")]
        public string Matricula { get; set; }


        [Required(ErrorMessage = "Selecione a turma")]
        public string IdTurma { get; set; }
        public List<SelectListItem> TurmaList { get; set; }

    }
}