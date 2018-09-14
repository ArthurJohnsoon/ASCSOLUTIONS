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
    public class TurmaRepository
    {
        public void Insert(Turma t)
        {
            using (DataContext ctx = new DataContext())
            {
                ctx.Entry(t).State = EntityState.Added;
                ctx.SaveChanges();
            }
        }

        public void Update(Turma t)
        {
            using (DataContext ctx = new DataContext())
            {
                ctx.Entry(t).State = EntityState.Modified;
                ctx.SaveChanges();
            }
        }

        public void Delete(Turma t)
        {
            using (DataContext ctx = new DataContext())
            {
                ctx.Entry(t).State = EntityState.Deleted;
                ctx.SaveChanges();
            }
        }

        public List<Turma> FindAll()
        {
            using (DataContext ctx = new DataContext())
            {
                return ctx.Turma.ToList();
            }
        }

        public Turma FindById(int idTurma)
        {
            using (DataContext ctx = new DataContext())
            {
                var turma = ctx.Turma.Single(x => x.IdTurma == idTurma);
                return turma;


            }
        }

    }
}
