using Entity.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Filme
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public DateTime DataLancamento { get; set; }
        public Classificacao Classificacao { get; set; }
        public int Duracao { get; set; }
        public int GeneroID { get; set; }

        public int CalcularDevolucao()
        {
            if (this.DataLancamento.Year == DateTime.Now.Year)
            {
                return 12;
            }
            int anosLancamento = DateTime.Now.Year - this.DataLancamento.Year;
            if (anosLancamento < 2)
            {
                return 24;
            }
            if (anosLancamento < 4)
            {
                return 36;
            }
            return 48;
        }

        public double CalcularPreco()
        {
            if (this.DataLancamento.Year == DateTime.Now.Year)
            {
                return 1;
            }
            int anosLancamento = DateTime.Now.Year - this.DataLancamento.Year;

            if (anosLancamento < 3)
            {
                return 8;
            }
            if (anosLancamento < 5)
            {
                return 6;
            }
            return 4;

        }
    }
}
