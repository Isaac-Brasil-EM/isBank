class TestaConta
{

    static void Main(string[] args)
    {
        Agencia agenciaA = new Agencia(1234);
        Agencia agenciaB = new Agencia(5678);
        Conta conta = new Conta(agenciaA);
        Conta contaDestino = new Conta(agenciaB);


        Console.WriteLine("Insira o nº da sua conta");
        int numero = Convert.ToInt32(Console.ReadLine());
        conta.numero = numero;

        Console.WriteLine("Insira o saldo da conta");
        double saldo = Convert.ToDouble(Console.ReadLine());
        conta.saldo = saldo;


        Console.WriteLine("Defina o limite da conta");
        double limite = Convert.ToDouble(Console.ReadLine());
        conta.limite = limite;

        int menuOption = 1;
        while (menuOption != 0)
        {
            System.Console.WriteLine("------------------------------------------------------------");
            System.Console.WriteLine("Bem Vindo ao IsBank! Digite a operação que deseja realizar: ");
            System.Console.WriteLine("1 - Efetuar Depósito ");
            System.Console.WriteLine("2 - Saque ");
            System.Console.WriteLine("3 - Imprimir Extrato ");
            System.Console.WriteLine("4 - Transferência Bancária ");
            System.Console.WriteLine("5 - Consultar informações bancárias ");
            System.Console.WriteLine("0 - Sair:");
            System.Console.WriteLine("------------------------------------------------------------");






            TextReader textReader = Console.In;
            string valorTela = textReader.ReadLine();
            menuOption = Convert.ToInt32(valorTela);

            if (menuOption == 1)
            {
                Console.WriteLine("Quanto você quer depositar ?");
                double valorDeposito = Convert.ToDouble(Console.ReadLine());
                conta.Deposita(valorDeposito);
                Console.WriteLine("Seu saldo agora é de: " + conta.saldo);


            }
            else if (menuOption == 2)
            {
                Console.WriteLine("Quanto você quer sacar ?");
                double valorSaque = Convert.ToDouble(Console.ReadLine());
                if (valorSaque > conta.saldo)
                {
                    conta.MensagemSaldoInsuficiente();

                }
                else
                {
                    conta.Saca(valorSaque);
                    conta.MensagemSucesso();
                }
                conta.ImprimeExtrato();
            }
            else if (menuOption == 3)
            {
                conta.ImprimeExtrato();
            }
            else if (menuOption == 4)
            {
                conta.ImprimeExtrato();
                Console.WriteLine("Insira o nº da conta destino: ");
                int nroContaDestino = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Qual valor você quer transferir?");
                double valorTransferencia = Convert.ToDouble(Console.ReadLine());
                if (valorTransferencia > conta.saldo)
                {
                    conta.MensagemSaldoInsuficiente();
                }
                else
                {
                    conta.Transfere(contaDestino, valorTransferencia);
                    conta.MensagemSucesso();
                }
                conta.ImprimeExtrato();

            }
            else if (menuOption == 5)
            {
                Console.WriteLine("Nº da sua conta: ");
                Console.WriteLine(conta.numero);
                Console.WriteLine("Nº da sua agencia: ");
                Console.WriteLine(conta.agencia.numero);

            }
        }
    }
}