using RestauranteADONET.Dominio.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestauranteADONET.EntityFramework.Configuracao
{
    public class TipoConfiguracao: EntityTypeConfiguration<Tipo>
    {
        public TipoConfiguracao()
        {
            HasKey(p => p.tipoId);
            Property(p => p.nome)
                .IsRequired()
                .HasMaxLength(150);
        }
    }
}
