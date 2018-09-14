using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Entities
{
    public class Aluno
    {
        public int IdAluno { get; set; }
        public string Nome { get; set; }
        public string Matricula { get; set; }

        [ForeignKey("IdTurma")]
        public virtual Turma Turma { get; set; }
        public int IdTurma { get; set; }
        public virtual List<Prova> Provas { get; set; }

        public Aluno()
        {
        }

        public Aluno(int idAluno, string nome, string matricula)
        {
            IdAluno = idAluno;
            Nome = nome;
            Matricula = matricula;
        }

        public override string ToString()
        {
            return $"Id: {IdAluno}, Nome: {Nome}, Matricula: {Matricula}";
        }
    }
}
