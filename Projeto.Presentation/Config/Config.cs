using Projeto.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace Projeto.Presentation.Config
{
    public class Config
    {
        public List<SelectListItem> retornaSelectListItem(List<Turma> turma)
        {
            var selectList = new List<SelectListItem>(
               from t in turma
               select new SelectListItem
               {
                   Text = t.Nome + " - " + t.Turno,
                   Value = t.IdTurma.ToString()
               });

            selectList.Insert(0, new SelectListItem() { Selected = true, Text = "Selecione", Value = "" });

            return selectList;
        }

        public List<SelectListItem> retornaSelectListItem(List<Aluno> alunos)
        {
            var selectList = new List<SelectListItem>(
               from t in alunos
               select new SelectListItem
               {
                   Text = t.Nome,
                   Value = t.IdTurma.ToString()
               });

            selectList.Insert(0, new SelectListItem() { Selected = true, Text = "Selecione", Value = "" });

            return selectList;
        }
    }
}