using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransferenciaBancariaDIO
{
    class Conta
    {
        public static int QtdContas { get; set; }
        public int NumConta { get; set; }
        public string Nome { get; set; }
        public double Saldo { get; private set; }
        public double Credito { get; private set; }
        public TipoPessoa TipoPessoa { get; private set; }

        public Conta (string nome, double credito, TipoPessoa tipoPessoa)
        {
            Nome = nome;
            Credito = credito;
            TipoPessoa = tipoPessoa;
            NumConta = QtdContas + 1;
            QtdContas++;
        }

        public void Deposito(double valor)
        {
            Saldo += valor;
        }

        public void Saque(double valor)
        {
            if (valor > (Saldo + Credito))
                Console.WriteLine("Saldo insuficiente para essa operação!");

            else
                Saldo -= valor;
        }

        public override string ToString()
        {
            return "Conta número: " + NumConta + ". Titular: " + Nome + ". Saldo de: R$ " + Saldo.ToString("F2");
        }
    }
}
