using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Calculadora_CentroMassa_CS_Console.Corpos;

namespace Calculadora_CentroMassa_CS_Console
{
    class Mapa
    {
        private static int linha = 22;
        private static int coluna = 52;
        char[,] mapa = new char[linha,coluna];

        public Mapa()
        {
            Borda();
        }

        public void ExibirMapa()
        {
            Console.WriteLine("                     **Mapa**");
            for (int l = 0; l < 22; l++)
            {
                for (int c = 0; c < 52; c++)
                {
                    Console.Write(mapa[l,c]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        private void Borda()
        {
            for (int l = 0; l < 22; l++)
            {
                for (int c = 0; c < 52; c++)
                {
                    if(l == 0 || l == 21)
                    {
                        mapa[l, c] = '―';
                    }
                    else if(c == 0 || c == 51)
                    {
                        mapa[l, c] = '|';
                    }
                    else
                    {
                        mapa[l, c] = ' ';
                    }    
                }
            }

        }

        public void AtualizarMapa()
        {
            CalcularCentro.CarregarMassa();
            CalcularCentro.CarregarLinha();
            CalcularCentro.CarregarColuna();
            CalcularCentro.EncontrarCentro();

            for (int l = 1; l < 21; l++)
            {
                for (int c = 1; c < 51; c++)
                {
                     mapa[l, c] = ' ';
                }
            }

            foreach(var item in Corpos.corpo)
            {
                mapa[item.linha, item.coluna] = 'x';
            }

            if(corpo.Count > 1)
            {
                mapa[CalcularCentro.linha, CalcularCentro.coluna] = '@';
            }
        }

    }
}
