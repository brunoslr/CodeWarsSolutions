using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsSolutions.Beta
{

    public class Doces
    {
        public static int ConteDoces(int quantidadeInicial, int novoACada)
        {
            int quantidadeAtual = quantidadeInicial;
            int comidos = 0;
            while(quantidadeAtual >= novoACada)
            {
                var quantidadeNovosDoces = quantidadeAtual / novoACada;
               
                comidos += novoACada * quantidadeNovosDoces;


                quantidadeAtual = quantidadeAtual % novoACada + quantidadeNovosDoces;
              
            }

            return comidos + quantidadeAtual;
        }


    }
}
