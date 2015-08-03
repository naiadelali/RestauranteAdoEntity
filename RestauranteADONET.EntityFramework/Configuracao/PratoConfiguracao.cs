using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using RestauranteADONET.Dominio.Model;
using System.Data.Entity.ModelConfiguration;

namespace RestauranteADONET.EntityFramework.Configuracao
{
    public class PratoConfiguracao : EntityTypeConfiguration<Prato>
    {
        public PratoConfiguracao()
        {
            HasKey(p => p.pratoId);
            Property(p => p.nome)
                .IsRequired()
                .HasMaxLength(150);
            Property(p => p.descricao)
                .HasMaxLength(250);
            HasRequired(p => p.tipo)
                .WithMany()
                .HasForeignKey(p => p.tipoId);
        }
    }
}
