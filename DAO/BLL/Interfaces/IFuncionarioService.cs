using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public interface IFuncionarioService
    {
        void Autenticar(string email, string senha);
    }
}
