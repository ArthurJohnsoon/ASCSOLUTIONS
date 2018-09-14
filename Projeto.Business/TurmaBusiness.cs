using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto.Entities; 
using Projeto.Repository.Persistence;
using System.Web;

namespace Projeto.Business
{
   public class TurmaBusiness
    {
       
        private TurmaRepository repository;
        
        public TurmaBusiness()
        {
            repository = new TurmaRepository();
        }
        
        public void CadastrarTurma(Turma t)
        {
            repository.Insert(t); 
        }
        
        public void AtualizarTurma(Turma t)
        {
            repository.Update(t); 
        }
        
        public void ExcluirTurma(Turma t)
        {
            repository.Delete(t); 
        }
        
        public List<Turma> ConsultarTurmas()
        {
            return repository.FindAll(); 
        }

        public Turma ObterTurmaPorId(int idTurma)
        {
            var turma = repository.FindById(idTurma);
            
            return turma;
        }

    }
}
