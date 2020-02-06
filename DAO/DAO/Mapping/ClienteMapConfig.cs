using Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO.Mapping
{
    internal class ClienteMapConfig : EntityTypeConfiguration<Cliente>
    {
        public ClienteMapConfig()
        {
            this.ToTable("CLIENTES");

            this.Property(c => c.Nome).HasMaxLength(50);
            this.Property(c => c.CPF).IsFixedLength().HasMaxLength(14);
            this.Property(c => c.DataNascimento).HasColumnType("date").IsRequired();
        }
    }
}
