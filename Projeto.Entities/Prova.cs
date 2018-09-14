using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Entities
{
    public class Prova
    {
        public int IdProva { get; set; }
        public float Nota { get; set; }

        [ForeignKey("IdAluno")]
        public virtual Aluno Aluno { get; set; }
        //Chave estrangeira
        public int IdAluno { get; set; }


        public Prova()
        {

        }

        public Prova(int idProva, float nota)
        {
            IdProva = idProva;
            Nota = nota;
        }

        public override string ToString()
        {
            return $"Id: {IdProva}, Nota: {Nota}";
        }
    }
}
