using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Entities
{
    public class Turma
    {
        public int IdTurma { get; set; }
        public string Nome { get; set; }
        public string Turno { get; set; }

        public virtual List<Aluno> Alunos { get; set; }

        public Turma()
        {

        }

        public Turma(int idTurma, string nome, string turno)
        {
            IdTurma = idTurma;
            Nome = nome;
            Turno = turno;
        }

        public override string ToString()
        {
            return $"Id: {IdTurma}, Nome: {Nome}, Tutno: {Turno}";
        }
    }
}
