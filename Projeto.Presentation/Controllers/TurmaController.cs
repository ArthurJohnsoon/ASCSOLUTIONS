using Projeto.Business;
using Projeto.Presentation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Projeto.Presentation.Controllers
{
    public class TurmaController : Controller
    {
        private readonly ProvaBusiness _provaBusiness;

        public TurmaController()
        {
            _provaBusiness = new ProvaBusiness();
        }
        // GET: Turma
        public ActionResult Consulta()
        {
            var list = _provaBusiness.ConsultarProvas();
            
            var listViewModel = new List<TurmaViewModels>();

            foreach (var item in list)
            {
                listViewModel.Add(new TurmaViewModels()
                {
                    Aluno = item.Aluno.Nome,
                    Matricula = item.Aluno.Matricula,
                    Turno = item.Aluno.Turma.Turno,
                    Nome = item.Aluno.Turma.Nome,
                    Prova1 = item.Nota.ToString()
                });
            }

            return View(listViewModel);
        }
    }
}