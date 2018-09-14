using Projeto.Business;
using Projeto.Entities;
using Projeto.Presentation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Projeto.Presentation.Controllers
{
    public class ProvaController : Controller
    {
        private readonly ProvaBusiness _business;
        private readonly AlunoBusiness _alunoBusiness;

        public ProvaController()
        {
            _alunoBusiness = new AlunoBusiness();
            _business = new ProvaBusiness();
        }

        // GET: Prova
        public ActionResult Cadastro()
        {

            var alunos = _alunoBusiness.ConsultarAlunos();

            var vieModel = new ProvaViewsModel()
            {
                AlunoList = new Config.Config().retornaSelectListItem(alunos)
            };

            return View(vieModel);
        }

        [HttpPost]
        public ActionResult Cadastro(ProvaViewsModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                   
                    Prova p = new Prova();
                    p.Nota = model.Nota;
                    p.Aluno = _alunoBusiness.ObterAlunoPorId(int.Parse(model.AlunoId));
                  
                    _business.CadastrarProva(p);

                    ViewBag.Mensagem = "Nota cadastrada com sucesso";
                    ModelState.Clear();
                }
                catch (Exception e)
                {

                    ViewBag.Mensagem = e.Message;
                }
            }

            var alunos = _alunoBusiness.ConsultarAlunos();

            var vieModel = new ProvaViewsModel()
            {
                AlunoList = new Config.Config().retornaSelectListItem(alunos)
            };

            return View(vieModel);
        }
    }
}