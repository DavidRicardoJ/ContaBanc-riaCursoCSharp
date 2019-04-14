using System;
using System.Globalization;

namespace ContaBancáriaCursoCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            double saldo = 0.0;

            Console.WriteLine("*** Conta Bancária ***\n");

            Console.Write("Entre o número da conta: ");
            int nConta = int.Parse(Console.ReadLine());

            Console.Write("Entre o titular da conta: ");
            string titular = Console.ReadLine();

            Console.Write("Haverá depósito inicial (s/n)? ");
            char resposta =Console.ReadKey().KeyChar;

            if (resposta == 's')
            {
                Console.Write("\nEntre o valor de depósito inicial: ");
                saldo = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            }
            Conta conta = new Conta(nConta, titular, saldo);
            Console.WriteLine("\nDados da conta:");
            Console.WriteLine(conta);

            Console.Write("\nEntre um valor para depósito: ");
            conta.Deposito(double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture));

            Console.WriteLine("\nDados da conta atualizados: ");
            Console.WriteLine(conta);

            Console.Write("\nEntre um valor para saque: ");
            conta.Saque(double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture));

            Console.WriteLine("\nDados da conta atualizados: ");
            Console.WriteLine(conta);
        }
    }
}
