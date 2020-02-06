using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Response
    {
        public bool Sucesso { get; set; }
        public List<string> Erros { get; set; }

        public string GetErrosMessage()
        {
            StringBuilder builder = new StringBuilder();

            foreach (string item in this.Erros)
            {
                builder.AppendLine(item);
            }
            return builder.ToString();
        }
        public bool HasErrors()
        {
            return this.Erros.Count > 0;
        }
        public Response()
        {
            this.Erros = new List<string>();
        }
    }
}
