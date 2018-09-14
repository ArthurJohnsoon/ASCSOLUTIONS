using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto.Entities;
using Projeto.Repository.Context;
using System.Data.Entity;

namespace Projeto.Repository.Persistence
{
    public class AlunoRepository
    {
        public void Insert(Aluno a)
        {
            using (DataContext ctx = new DataContext())
            {
                ctx.Entry(a).State = EntityState.Added;
                ctx.SaveChanges(); 
            }
        }
        
        public void Update(Aluno a)
        {
            using (DataContext ctx = new DataContext())
            {
                ctx.Entry(a).State = EntityState.Modified; 
                ctx.SaveChanges();
            }
        }
        
        public void Delete(Aluno a)
        {
            using (DataContext ctx = new DataContext())
            {
                ctx.Entry(a).State = EntityState.Deleted; 
                ctx.SaveChanges();
            }
        }
        
        public List<Aluno> FindAll()
        {
            using (DataContext ctx = new DataContext())
            {
                return ctx.Aluno.ToList(); 
            }
        }
        
        public Aluno FindById(int idAluno)
        {
            using (DataContext ctx = new DataContext())
            {
                return ctx.Aluno.Find(idAluno);
            }
        }

    }
    
}
