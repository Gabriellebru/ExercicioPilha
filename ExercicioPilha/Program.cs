using ExercicioPilha.Entidades;
using System;
using System.Collections;
using System.Collections.Generic;

namespace ExercicioPilha
{
    class Program
    {
        static void Main(string[] args)
        {
            PilhaEstatica<Container> pilha1 = new PilhaEstatica<Container>(3);
            PilhaEstatica<Container> pilha2 = new PilhaEstatica<Container>(3);
            PilhaEstatica<Container> pilha3 = new PilhaEstatica<Container>(3);
            PilhaEstatica<Container> pilha4 = new PilhaEstatica<Container>(3);

            int escolha = -1;
            int codigo = 0;

            while (escolha != 0)
            {
                escolha = Util.MenuInicial();
                switch (escolha)
                {
                    case 1:
                        Util.SubMenu1();
                        try
                        {
                            codigo = int.Parse(Console.ReadLine());
                            if (!Util.VerificaCodigoRepetido(codigo, pilha1, pilha2, pilha3, pilha4))
                            {
                                if (pilha1.Tamanho() < 3 || pilha2.Tamanho() < 3 || pilha3.Tamanho() < 3 || pilha4.Tamanho() < 3)
                                {
                                    if (pilha1.Tamanho() <= pilha2.Tamanho() && pilha1.Tamanho() <= pilha3.Tamanho() && pilha1.Tamanho() <= pilha4.Tamanho())
                                    {
                                        pilha1.Empilha(new Container(codigo));
                                    }
                                    else if (pilha2.Tamanho() <= pilha3.Tamanho() && pilha2.Tamanho() <= pilha4.Tamanho())
                                    {
                                        pilha2.Empilha(new Container(codigo));
                                    }
                                    else if (pilha3.Tamanho() <= pilha4.Tamanho())
                                    {
                                        pilha3.Empilha(new Container(codigo));
                                    }
                                    else
                                    {
                                        pilha4.Empilha(new Container(codigo));
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("\n\nImpossível empilhar");
                                    Console.WriteLine("\nPressione ENTER para continuar");
                                    Console.ReadLine();
                                }
                            }
                            else
                            {
                                Console.WriteLine("\n\nCódigo inválido!");
                                Console.WriteLine("\nPressione ENTER para continuar");
                                Console.ReadLine();
                            }
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("\n\nCódigo inválido!");
                            Console.WriteLine("\nPressione ENTER para continuar");
                            Console.ReadLine();
                        }

                        break;
                    case 2:
                        Util.MostrarPilhas(pilha1, pilha2, pilha3, pilha4);
                        Util.SubMenu2();
                        try
                        {
                            codigo = int.Parse(Console.ReadLine());

                            if (Util.VerificaCodigoRepetido(codigo, pilha1, pilha2, pilha3, pilha4))
                            {
                                if (pilha1.Tamanho() > 0 || pilha2.Tamanho() > 0 || pilha3.Tamanho() > 0 || pilha4.Tamanho() > 0)
                                {

                                    if (pilha1.Tamanho() > 0 && pilha1.Topo().PegaCodigo() == codigo)
                                    {
                                        pilha1.Desempilha();
                                    }
                                    else if (pilha2.Tamanho() > 0 && pilha2.Topo().PegaCodigo() == codigo)
                                    {
                                        pilha2.Desempilha();
                                    }
                                    else if (pilha3.Tamanho() > 0 && pilha3.Topo().PegaCodigo() == codigo)
                                    {
                                        pilha3.Desempilha();
                                    }
                                    else if (pilha4.Tamanho() > 0 && pilha4.Topo().PegaCodigo() == codigo)
                                    {
                                        pilha4.Desempilha();
                                    }
                                    else
                                    {
                                        Console.WriteLine("\n\nImpossível desempilhar");
                                        Console.WriteLine("\nPressione ENTER para continuar");
                                        Console.ReadLine();
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("\n\nImpossível desempilhar");
                                    Console.WriteLine("\nPressione ENTER para continuar");
                                    Console.ReadLine();
                                }
                            }
                            else
                            {
                                Console.WriteLine("\n\nCódigo inválido!");
                                Console.WriteLine("\nPressione ENTER para continuar");
                                Console.ReadLine();
                            }
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("\n\nCódigo inválido!");
                            Console.WriteLine("\nPressione ENTER para continuar");
                            Console.ReadLine();
                        }
                        break;
                    case 3:
                        Util.MostrarPilhas(pilha1, pilha2, pilha3, pilha4);
                        Console.WriteLine("\nPressione ENTER para continuar");
                        Console.ReadLine();
                        break;
                    case 0:
                        break;
                    default:
                        Util.OpcaoInvalida();
                        break;
                }
            }

        }
    }
}
