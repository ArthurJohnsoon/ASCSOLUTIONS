using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using Projeto.Entities;

namespace Projeto.Repository.Mappings
{
    public class ProvaMap : EntityTypeConfiguration<Prova>
    {
        public ProvaMap()
        {
            ToTable("Prova");
            
            HasKey(p => p.IdProva);
            
            Property(p => p.IdProva)
                .HasColumnName("IdProva")
                .IsRequired();

            Property(p => p.Nota)
                .HasColumnName("Nota")
                .IsRequired();

            HasRequired(s => s.Aluno)
                  .WithMany(g => g.Provas);
        }
    }
}
