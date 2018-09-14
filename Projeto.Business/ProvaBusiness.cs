using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto.Entities; 
using Projeto.Repository.Persistence;


namespace Projeto.Business
{
   public class ProvaBusiness
    {
        private ProvaRepository repository;
        
        public ProvaBusiness()
        {
            repository = new ProvaRepository();
        }
        
        public void CadastrarProva(Prova p)
        {
            repository.Insert(p); 
        }
        
        public void AtualizarProva(Prova p)
        {
            repository.Update(p); 
        }
        
        public void ExcluirProva(Prova p)
        {
            repository.Delete(p); 
        }
        
        public List<Prova> ConsultarProvas()
        {
            return repository.FindAll(); 
        }
        
        public Prova ObterProvaPorId(int idProva)
        {
            return repository.FindById(idProva); 
        }

    }
}
