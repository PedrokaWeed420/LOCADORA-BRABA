using Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO.Mapping
{
    internal class FuncionarioMapConfig : EntityTypeConfiguration<Funcionario>
    {
        public FuncionarioMapConfig()
        {
            this.ToTable("FUNCIONARIOS");
            this.Property(f => f.Nome).HasMaxLength(50);
            this.Property(f => f.Email).HasMaxLength(80);
            this.Property(f => f.CPF).IsFixedLength().HasMaxLength(14);
            this.Property(f => f.DataNascimento).HasColumnType("date").IsRequired();
            this.Property(f => f.Telefone).IsFixedLength().HasMaxLength(15);
            this.Property(f => f.Senha).HasMaxLength(30);
        }
    }
}
