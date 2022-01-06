using System;

/* Manter índice quando modificar
 * Mostrar centro de massa
 */

namespace Calculadora_CentroMassa_CS_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Mapa mapa = new Mapa();
            
            while (true)
            {
                ExibeMenu();
                mapa.ExibirMapa();
                Console.WriteLine("Digite uma opção. Aguardando...");
                int opcao;
                try
                {
                    opcao = Int32.Parse(Console.ReadLine());
                    Executar(opcao);
                }
                catch (Exception)
                {
                    Console.WriteLine("Opção inválida de menu.");
                }                
                mapa.AtualizarMapa();
                                             
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
            Console.WriteLine("4 - Listar");
            Console.WriteLine("5 - Sair\n");
        }

        static void Executar(int opcao)
        {
            switch (opcao)
            {
                case 1:
                    try
                    {
                        int[] coord = PegarCoordenadas();
                        Console.WriteLine("Digite massa: ");
                        float massa = float.Parse(Console.ReadLine());
                        Corpos.Adicionar(coord[0], coord[1], massa, 0, 0);
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Valor digitado não é um inteiro. Corpo não adicionado.");
                    }                    
                    break;

                case 2:
                    try
                    {
                        Console.WriteLine("Digite ID a ser removido: ");
                        int idRemover = Int32.Parse(Console.ReadLine());

                        Corpos.Remover(idRemover);
                        
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Valor digitado não é um inteiro. Corpo não removido.");
                    }
                    break;

                case 3:
                    int id;
                    try
                    {
                        Console.WriteLine("Digite ID a ser alterado: ");
                        int idRemover = Int32.Parse(Console.ReadLine());
                        id = Corpos.Remover(idRemover);
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Valor digitado não é um inteiro. Corpo inalterado.");
                        break;
                    }

                    try
                    {
                        Console.WriteLine("Atualize as informações: ");
                        int[] coord = PegarCoordenadas();
                        Console.WriteLine("Digite massa: ");
                        float massa = float.Parse(Console.ReadLine());
                        Corpos.Adicionar(coord[0], coord[1], massa, 1, id);
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Valor digitado não é um inteiro. Corpo corrompido removido.");
                    }
                    
                    break;

                case 4:
                    Corpos.Listar();
                    break;

                case 5:
                    System.Environment.Exit(1);
                    break;

                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }
        }

        static int[] PegarCoordenadas()
        {
            //0 linha, 1 coluna.
            int[] lc = new int[2];

            Console.WriteLine("Digite a linha (1-20) e coluna (1-50): ");

            try
            {
                do
                {
                    lc[0] = Int32.Parse(Console.ReadLine());
                    lc[1] = Int32.Parse(Console.ReadLine());
                } while (lc[0] < 1 || lc[0] > 20 || lc[1] < 1 || lc[1] > 50);
            }
            catch(Exception)
            {
                throw;
            }
            
            return lc;
        }

    }
}
