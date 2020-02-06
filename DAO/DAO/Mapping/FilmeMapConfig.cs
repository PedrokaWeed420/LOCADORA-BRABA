using Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO.Mapping
{
    internal class FilmeMapConfig : EntityTypeConfiguration<Filme>
    {
        public FilmeMapConfig()
        {
            this.ToTable("FILMES");
            this.Property(f => f.Nome).HasMaxLength(50);
            this.Property(f => f.DataLancamento).HasColumnType("date").IsRequired();
        }
    }
}
