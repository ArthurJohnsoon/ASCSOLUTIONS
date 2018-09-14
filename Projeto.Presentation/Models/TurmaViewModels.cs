using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Projeto.Presentation.Models
{
    public class TurmaViewModels
    {
        public string Nome { get; set; }
        public string Turno { get; set; }
        public string Aluno { get; set; }
        public string Matricula { get; set; }
        public string Prova1 { get; set; }
        public string Prova2 { get; set; }
        public string Prova3 { get; set; }
    }
}