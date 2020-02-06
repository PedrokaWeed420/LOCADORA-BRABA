using Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    class LocacaoTesteStrategy : DropCreateDatabaseAlways<LocacaoDbContext>
    {
        protected override void Seed(LocacaoDbContext context)
        {
                Cliente c = new Cliente()
                {
                    Nome = "Necão",
                    EhAtivo = true,
                    CPF = "901.917.069-41",
                    DataNascimento = DateTime.Now.AddYears(-55),
                    Email = "bernard@gmail.com"
                };
                context.Clientes.Add(c);
                context.SaveChanges();
            base.Seed(context);
        }
    }
}
