using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Calculadora_CentroMassa_CS_Console.Corpos;

namespace Calculadora_CentroMassa_CS_Console
{
    static public class CalcularCentro
    {
        /* colocar no mapa
         * adicionar legenda*/

        private static float linhaTotal;
        private static float colunaTotal;
        private static float massaTotal;
        public static int linha;
        public static int coluna;

        public static void CarregarMassa()
        {
            massaTotal = 0;
            foreach (var item in corpo)
            {
                massaTotal += item.massa;
            }
            Console.WriteLine(massaTotal);
        }

        public static void CarregarLinha()
        {
            linhaTotal = 0;
            float linhaTmp;
            foreach (var item in corpo)
            {
                linhaTmp = item.linha * item.massa;
                linhaTotal += linhaTmp;
            }
            Console.WriteLine(linhaTotal);
        }

        public static void CarregarColuna()
        {
            colunaTotal = 0;
            float colunaTmp;
            foreach (var item in corpo)
            {
                colunaTmp = item.coluna * item.massa;
                colunaTotal += colunaTmp;
            }
            Console.WriteLine(colunaTotal);
        }

        public static void EncontrarCentro()
        {
            float resultado;
            resultado = linhaTotal / massaTotal;
            linha = (int)resultado;

            resultado = colunaTotal / massaTotal;
            coluna = (int)resultado;

            Console.WriteLine(linha + " " + coluna);
        }

    }
}
