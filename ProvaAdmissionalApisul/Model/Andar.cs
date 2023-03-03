using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaAdmissionalApisul.Model
{
    public class Andar
    {
        public int NumeroAndar { get; set; }
        public int Quantidade { get; set; }

        public Andar(int numeroAndar, int quantidade) 
        {
            NumeroAndar = numeroAndar;
            Quantidade = quantidade;
        }
    }
}
