using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using Projeto.Entities;

namespace Projeto.Repository.Mappings
{
   public class TurmaMap : EntityTypeConfiguration<Turma>
    {
        public TurmaMap()
        {
            ToTable("Turma");
            
            HasKey(f => f.IdTurma);
            
            Property(f => f.IdTurma)
                .HasColumnName("IdTurma")
                .IsRequired();

            Property(f => f.Nome)
                .HasColumnName("Nome")
                .HasMaxLength(50)
                .IsRequired();

            Property(f => f.Turno)
                .HasColumnName("Turno")
                .IsRequired();
            
             HasMany(g => g.Alunos)
                .WithRequired(s => s.Turma)
                .WillCascadeOnDelete();

        }
   }
}
