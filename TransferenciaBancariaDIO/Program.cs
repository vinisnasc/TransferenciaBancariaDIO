using System;
using System.Collections.Generic;

namespace TransferenciaBancariaDIO
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Conta> listaContas = new List<Conta>();

            Console.WriteLine("Bem vindo ao seu banco!");
            
            string opcaoUsuario = Menu.OpcaoUsuario();

            while (opcaoUsuario != "X")
            {
                switch (opcaoUsuario)
                {
                    case "1":
                        listaContas.Add(Menu.AddConta());
                        break;

                    case "2":
                        Console.WriteLine();
                        foreach (Conta obj in listaContas)
                            Console.WriteLine(obj);
                        break;

                    case "3":
                        Menu.MenuDeposito(listaContas);
                        break;

                    case "4":
                        Menu.MenuSaque(listaContas);
                        break;

                    case "5":
                        Menu.Transferir(listaContas);
                        break;

                    case "C":
                        Console.Clear();
                        break;

                    default:
                        Console.WriteLine("Opção inválida, digite uma opção válida!");
                        break;
                }
                Console.WriteLine();
                opcaoUsuario = Menu.OpcaoUsuario();
            }

            Console.WriteLine("Obrigado por utilizar nossos serviços!");
                
        }

        
    }
}
