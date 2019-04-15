using System;

namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo ao OnurBank");

            ContaCorrente conta1 = new ContaCorrente();
            Console.WriteLine("Digite o nome do Títular");
            conta1.titular = Console.ReadLine();
            Console.WriteLine("Número da Agência:");
            conta1.agencia = int.Parse(Console.ReadLine());
            Console.WriteLine("Numero da Conta:");
            conta1.numeroConta = int.Parse(Console.ReadLine());
            conta1.Depositar(1000);
            // Console.WriteLine("Deseja sacar quanto");
            // double valor = double.Parse(Console.ReadLine());
            // bool resultado = conta1.Sacar(valor);

            ContaCorrente conta2 = new ContaCorrente();
             Console.WriteLine("Digite o nome do Títular");
            conta2.titular = Console.ReadLine();
            Console.WriteLine("Número da Agência:");
            conta2.agencia = int.Parse(Console.ReadLine());
            Console.WriteLine("Numero da Conta:");
            conta2.numeroConta = int.Parse(Console.ReadLine());
            conta2.Depositar(3000);
            // Console.WriteLine("Deseja sacar quanto");
            // double valor2 = double.Parse(Console.ReadLine());
            // bool resultado2 = conta2.Sacar(valor2);



            Console.WriteLine($"------------------------------------");
            Console.WriteLine($"Titular {conta1.titular}");
            Console.WriteLine($"Agência {conta1.agencia}");
            Console.WriteLine($"Numero da conta {conta1.numeroConta}");
            Console.WriteLine($"Saldo {conta1.saldo}");
            Console.WriteLine($"------------------------------------");
            
            Console.WriteLine($"------------------------------------");
            Console.WriteLine($"Titular {conta2.titular}");
            Console.WriteLine($"Agência {conta2.agencia}");
            Console.WriteLine($"Numero da conta {conta2.numeroConta}");
            Console.WriteLine($"Saldo {conta2.saldo}");
            Console.WriteLine($"------------------------------------");

            bool resultadoTransferencia = true;
            do
            {
                
            Console.WriteLine("Quanto deseja transferir da conta1 para a conta2");
            double valorTransferencia = double.Parse (Console.ReadLine());
            resultadoTransferencia = conta1.Transferir()
            } while (true);
            


            Console.WriteLine ($"----------Resultado Após Transferencia----------");
            Console.WriteLine ($"Saldo da conta1: {conta1.saldo}");
            Console.WriteLine ($"Saldo da conta2: {conta2.saldo}");        
        }
    }
}
