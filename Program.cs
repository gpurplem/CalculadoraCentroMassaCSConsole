using System;

namespace Calculadora_CentroMassa_CS_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Mapa mapa = new Mapa();
            Corpos corpo = new Corpos();
            
            while (true)
            {
                ExibeMenu();
                mapa.ExibirMapa();
                Console.WriteLine("Digite uma opção. Aguardando...");
                int opcao = Console.Read();
                Executar(opcao, corpo);
                //Console.SetCursorPosition(0, 0);

                foreach (var item in corpo)
                {

                }


                Console.ReadLine();
                Console.Clear();
            }
        }

        static void ExibeMenu()
        {
            Console.WriteLine("\n         ***Calculadora de Centro de Massa***\n");
            Console.WriteLine("*MENU*");
            Console.WriteLine("1 - Adicionar");
            Console.WriteLine("2 - Remover");
            Console.WriteLine("3 - Modificar");
            Console.WriteLine("4 - Sair\n");
        }

        static void Executar(int opcao, Corpos corpo)
        {
            switch (opcao)
            {
                case 1:
                    Console.WriteLine("Digite coordenadas (x <enter> y): ");
                    int l = Int32.Parse(Console.ReadLine());
                    int c = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("Digite massa: ");
                    float massa = float.Parse(Console.ReadLine());
                    corpo.Adicionar(l, c, massa);
                    break;

                case 4:
                    System.Environment.Exit(1);
                    break;
            }

        }

    }
}
