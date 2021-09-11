using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioPilha.Entidades
{
    public static class Util
    {
        public static int MenuInicial()
        {
            Console.Clear();
            Console.WriteLine("INICIO\n");
            Console.WriteLine("1 - Adicionar container");
            Console.WriteLine("2 - Remover container");
            Console.WriteLine("3 - Visualizar pilhas de containers");
            Console.WriteLine("0 - Sair\n");
            Console.Write("escolha: ");

            return PegaCodigo();
        }

        public static void SubMenu1()
        {
            Console.Clear();
            Console.Write("Digite o código do container para adicionar: ");
        }

        public static void SubMenu2()
        {
            Console.Write("Digite o código do container para remover: ");
        }

        public static void OpcaoInvalida()
        {
            Console.WriteLine("Opção inválida, tente novamente.");
            Console.WriteLine("pressione ENTER para continuar...");
            Console.ReadLine();
        }

        public static void MostrarPilhas(params PilhaEstatica<Container>[] Pilhas)
        {
            int count = 1;
            Console.Clear();
            Console.WriteLine("Lista de Pilhas\n");
            foreach (PilhaEstatica<Container> pilha in Pilhas)
            {
                if (pilha.Tamanho() > 0)
                {
                    Console.WriteLine($"\tPilha {count}");
                }

                foreach (Container item in pilha.RetornaTodosElementos())
                {
                    Console.WriteLine($"\t\tCódigo container {item.PegaCodigo()}\n");
                }
                count++;
            }
        }

        private static int PegaCodigo()
        {
            try
            {
                return int.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                return -1;
            }
        }

        public static bool VerificaCodigoRepetido(int codigo, params PilhaEstatica<Container>[] Pilhas)
        {
            bool CodigoExiste = false;
            foreach (PilhaEstatica<Container> Pilha in Pilhas)
            {
                foreach (Container container in Pilha.RetornaTodosElementos())
                {
                    if (container.PegaCodigo() == codigo)
                    {
                        CodigoExiste = true;
                    }
                }
            }
            return CodigoExiste;
        }
    }
}
