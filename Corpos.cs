using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_CentroMassa_CS_Console
{
    public static class Corpos
    {
        private static int _ID = 0;
        public struct _corpo_{
            int id;
            int linha;
            int coluna;
            float massa;

            public _corpo_(int id, int linha, int coluna, float massa)
            {
                this.id = id;
                this.linha = linha;
                this.coluna = coluna;
                this.massa = massa;
            }
        }

        List<_corpo_> corpo = new List<_corpo_>();

        public void Adicionar(int l, int c, float m)
        {
            corpo.Add(new _corpo_(_ID, l, c, m));
            _ID++;
        }




    }
}
