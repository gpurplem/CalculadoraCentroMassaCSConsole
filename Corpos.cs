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
            public int id;
            public int linha;
            public int coluna;
            public float massa;

            public _corpo_(int id, int linha, int coluna, float massa)
            {
                this.id = id;
                this.linha = linha;
                this.coluna = coluna;
                this.massa = massa;
            }
        }

        static public List<_corpo_> corpo = new List<_corpo_>();

        //controle = 0, muda ID, != 0, não muda ID.
        public static void Adicionar(int l, int c, float m, int controle, int idOriginal)
        {
            if(controle == 0)
            {
                corpo.Add(new _corpo_(_ID, l, c, m));
                _ID++;
            }
            else
            {
                corpo.Add(new _corpo_(idOriginal, l, c, m));
            }            
        }

        public static int Remover(int idRemover)
        {
            int id = corpo.FindIndex(corpo => corpo.id == idRemover);
            corpo.RemoveAt(id);
            return id;
        }

        public static void Listar()
        {
            if(corpo.Count == 0)
            {
                Console.WriteLine("Lista vazia.");
                return;
            }

            foreach (var item in corpo)
            {
                Console.WriteLine($"ID: {item.id}, linha: {item.linha}, coluna: {item.coluna}, massa: {item.massa}");
            }
        }
    }
}
