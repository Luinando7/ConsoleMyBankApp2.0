using System;

namespace ConsoleMyBankApp2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente = new Cliente("Luis Fernando Basilio", "000.000.000-00", "Desenvolvedor");


            ContaCorrente conta = new ContaCorrente(cliente, 01, 0001);

            Console.WriteLine("Conta Corrente Criada");
            Console.WriteLine("Titular: {0}", conta.getTitular().getNome());
            Console.WriteLine("Agencia: {0}", conta.getAgencia());
            Console.WriteLine("Conta: {0}", conta.getConta());

            Console.WriteLine("Parabéns seu saldo é de R${0}, obrigado por criar sua conta", conta.getSaldo());

            double valorDeposito = 100;
            conta.Depositar(valorDeposito);

            Console.WriteLine("Seu saldo é de R${0}", conta.getSaldo());

            double valorSaque = 200;
            conta.Sacar(valorSaque);

            Console.WriteLine("Seu saldo é de R${0}", conta.getSaldo());

            Cliente clienteSilva = new Cliente("Silva Mendes Oliveira", "000.000.000-00", "Administradora");

            ContaCorrente contaSilva = new ContaCorrente(clienteSilva, 01, 0002);

            double valorPix = 100;
            conta.Pix(valorPix, contaSilva);

            Console.WriteLine("Seu saldo é de R${0}", conta.getSaldo());
            Console.WriteLine("Seu saldo é de R${0}", contaSilva.getSaldo());

            ContaPoupanca contaPoupanca = new ContaPoupanca(cliente, 01, 0003);

            Console.WriteLine("Conta Poupança criada");
            Console.WriteLine("Titular: {0}", contaPoupanca.getTitular().getNome());
            Console.WriteLine("Agencia: {0}", contaPoupanca.getAgencia());
            Console.WriteLine("Conta: {0}", contaPoupanca.getConta());
        }
    }
}
