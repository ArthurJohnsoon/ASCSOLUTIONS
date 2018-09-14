using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Projeto.Entities;
using Projeto.Repository.Context;


namespace Projeto.Repository.Persistence
{
    public class ProvaRepository
    {
        public void Insert(Prova p)
        {
            using (DataContext ctx = new DataContext())
            {
                ctx.Entry(p).State = EntityState.Added; 
                ctx.SaveChanges(); 
            }
        }

        public void Update(Prova p)
        {
            using (DataContext ctx = new DataContext())
            {
                ctx.Entry(p).State = EntityState.Modified; 
                ctx.SaveChanges();
            }
        }

        public void Delete(Prova p)
        {
            using (DataContext ctx = new DataContext())
            {
                ctx.Entry(p).State = EntityState.Deleted; 
                ctx.SaveChanges();
            }
        }
        
        public List<Prova> FindAll()
        {
            using (DataContext ctx = new DataContext())
            {
                return ctx.Prova.Include(x=>x.Aluno)
                                .Include(x => x.Aluno.Turma)
                                .ToList(); 
            }
        }
        
        public Prova FindById(int idProva)
        {
            using (DataContext ctx = new DataContext())
            {
                return ctx.Prova.Find(idProva);
            }
        }

    }
}
