using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Projeto.Presentation.Models
{
    public class ProvaViewsModel
    {
        [Required]
        [Range(0,10)]
        public float Nota { get; set; }

        [Required]
        public string AlunoId { get; set; }
        public List<SelectListItem> AlunoList { get; set; }

    }
}