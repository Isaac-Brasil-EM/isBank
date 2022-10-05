class TestaGerente {

    static void Main(string[] args)
    {
        Console.WriteLine("Insira o nome do funcionario: ");
        string nomeFuncionario = Console.ReadLine();

        Gerente g = new Gerente(nomeFuncionario, 1232);
        Console.WriteLine("Salário: " + g.salario);

        Console.WriteLine("Aumentando o salário em 10% ");
        g.AumentaSalario();
        Console.WriteLine("Salário: " + g.salario);

        Console.WriteLine("Aumentando o salário em 30% ");
        g.AumentaSalario(0.3);
        Console.WriteLine("Salário: " + g.salario);

    }

}