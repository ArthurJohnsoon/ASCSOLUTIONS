using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Projeto.Repository.Mappings
{
    public class AlunoMap : EntityTypeConfiguration<Aluno>
    {
        public AlunoMap()
        {
            ToTable("Aluno");
            
            HasKey(a => a.IdAluno);
            
            Property(a => a.IdAluno)
                .HasColumnName("IdAluno")
                .IsRequired();

            Property(a => a.Nome)
                .HasColumnName("Nome")
                .HasMaxLength(50)
                .IsRequired();

            Property(a => a.Matricula)
                .HasColumnName("Matricula")
                .IsRequired();
            
             HasMany(g => g.Provas)
                .WithRequired(s => s.Aluno)
                .WillCascadeOnDelete();

             HasRequired(s => s.Turma)
                .WithMany(g => g.Alunos);
        }
    }
}
