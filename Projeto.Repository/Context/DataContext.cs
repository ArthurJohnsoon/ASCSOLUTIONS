using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.Entity;
using Projeto.Entities;
using Projeto.Repository.Mappings;


namespace Projeto.Repository.Context
{
    public class DataContext : DbContext
    {
        public DataContext()
            : base(ConfigurationManager.ConnectionStrings
            ["projeto"].ConnectionString)
        {
           
        }

       
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AlunoMap());
            modelBuilder.Configurations.Add(new ProvaMap());
            modelBuilder.Configurations.Add(new TurmaMap());
        }
        
        public DbSet<Aluno> Aluno { get; set; } 
        public DbSet<Prova> Prova { get; set; }
        public DbSet<Turma> Turma { get; set; }
    }

}
