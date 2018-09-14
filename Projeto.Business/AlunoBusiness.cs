using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto.Entities;
using Projeto.Repository.Persistence;


namespace Projeto.Business
{
    public class AlunoBusiness
    {
        private AlunoRepository repository;
        
        public AlunoBusiness()
        {
            repository = new AlunoRepository();
        }
        
        public void CadastrarAluno(Aluno a)
        {
            repository.Insert(a); 
        }
        
        public void AtualizarAluno(Aluno a)
        {
            repository.Update(a); 
        }
        
        public void ExcluirAluno(Aluno a)
        {
            repository.Delete(a);
        }
        
        public List<Aluno> ConsultarAlunos()
        {
            return repository.FindAll(); 
        }
        
        public Aluno ObterAlunoPorId(int idAluno)
        {
            return repository.FindById(idAluno); 
        }


        
    }
}
