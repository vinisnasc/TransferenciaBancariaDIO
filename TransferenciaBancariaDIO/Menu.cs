using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransferenciaBancariaDIO
{
    class Menu
    {
        public static string OpcaoUsuario()
        {
            Console.WriteLine("Digite a operação que deseja fazer: " +
                              "\n1 - para criar nova conta" +
                              "\n2 - listar contas" +
                              "\n3 - para deposito" +
                              "\n4 - para saque" +
                              "\n5 - para transferencia" +
                              "\nC - para limpar a tela" +
                              "\nX - para sair");
            return Console.ReadLine().ToUpper();
        }

        public static Conta AddConta()
        {
            Console.Clear();
            Console.WriteLine("Para criar uma nova conta, siga as instruções abaixo: ");
            Console.Write("Digite o nome do cliente: ");
            string nome = Console.ReadLine();
            Console.Write("Digite o tipo de Pessoa (1 para física, 2 para jurídica) ");
            int tipoPessoa = int.Parse(Console.ReadLine());
            Console.Write("Quanto será o crédito desta conta? ");
            double credito = double.Parse(Console.ReadLine());

            Conta novaConta = new Conta(nome, credito, (TipoPessoa)tipoPessoa);

            Console.WriteLine($"\nConta criada! \n{novaConta}");

            return novaConta;
        }

        public static void MenuDeposito(List<Conta> listaContas)
        {
            Console.Write("Digite o numero da conta que fará deposito: ");
            int numConta = int.Parse(Console.ReadLine());

            Conta c1 = listaContas.Find(x => x.NumConta == numConta);

            Console.Write("Qual será o valor do depósito? ");
            double deposito = double.Parse(Console.ReadLine());
            c1.Deposito(deposito);

            Console.WriteLine($"\nDeposito realizado!\n{c1}");
        }

        public static void MenuSaque(List<Conta> listaContas)
        {
            Console.Write("Digite o numero da conta que você deseja realizar um saque: ");
            int numConta = int.Parse(Console.ReadLine());

            Conta c1 = listaContas.Find(x => x.NumConta == numConta);

            Console.Write("Qual será o valor do saque? ");
            double saque = double.Parse(Console.ReadLine());
            c1.Saque(saque);
        }

        public static void Transferir(List<Conta> listaContas)
        {
            Console.Write("Digite o numero da conta que fará uma transferencia: ");
            int origem = int.Parse(Console.ReadLine());
            Console.Write("Digite o numero da conta que receberá a transferencia: ");
            int destino = int.Parse(Console.ReadLine());

            Conta c1 = listaContas.Find(x => x.NumConta == origem);
            Conta c2 = listaContas.Find(x => x.NumConta == destino);

            Console.Write("Digite o valor da transferencia: ");
            double valor = double.Parse(Console.ReadLine());

            c1.Saque(valor);
            c2.Deposito(valor);
        }
    }
}
