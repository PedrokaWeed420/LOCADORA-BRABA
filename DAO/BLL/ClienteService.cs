using BLL.Interfaces;
using DAO;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ClienteService : IClienteService
    {
        public void Insert(Cliente cliente)
        {
            using (LocacaoDbContext db = new LocacaoDbContext())
            {
                Cliente cli = new Cliente()
                {
                    Nome = "Dani",
                    EhAtivo = true,
                    CPF = "901.901.901-21",
                    DataNascimento = DateTime.Now.AddYears(-55)
                };
                    db.Clientes.Add(cli);
                    db.SaveChanges();
                
            }
        }
    }
}
