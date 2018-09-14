using Projeto.Presentation.Models;
using System;
using System.Linq;
using System.Web.Mvc;
using Projeto.Entities;
using Projeto.Business;
using System.Collections.Generic;

namespace Projeto.Presentation.Controllers
{
    public class AlunoController : Controller
    {

        private readonly AlunoBusiness _business;
        private readonly TurmaBusiness _turmaBusiness;

        public AlunoController()
        {
            _business = new AlunoBusiness();
            _turmaBusiness = new TurmaBusiness();
        }

        public ActionResult Cadastro()
        {
            var turmas = _turmaBusiness.ConsultarTurmas();
            
            var vieModel = new AlunoViewsModel()
            {
                TurmaList = new Config.Config().retornaSelectListItem(turmas)
            };

            return View(vieModel);
        }

        [HttpPost]
        public ActionResult Cadastro(AlunoViewsModel model)
        {


            if (ModelState.IsValid)
            {
                try
                {
                    Aluno a = new Aluno();
                    a.Nome = model.Nome;
                    a.Matricula = model.Matricula;
                    a.Turma = _turmaBusiness.ObterTurmaPorId(int.Parse(model.IdTurma));
                    _business.CadastrarAluno(a);

                    ViewBag.Mensagem = "Aluno cadastrado com sucesso.";
                    ModelState.Clear();
                }
                catch (Exception e)
                {

                    ViewBag.Mensagem = e.Message;
                }
            }

            var turmas = _turmaBusiness.ConsultarTurmas();

            var vieModel = new AlunoViewsModel()
            {
                TurmaList = new Config.Config().retornaSelectListItem(turmas)
            };

            return View(vieModel);
        }

    }
}