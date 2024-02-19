using BancoNovo;

Menu.BoasVindas();

int opcao = 1;
Conta contaLogada = null;
while (opcao != 0)
{
    Menu.MostrarMenu();
    opcao = int.Parse(Console.ReadLine());

    switch (opcao)
    {
        case 1:
            contaLogada.MostrarSaldo();
            break;
        case 2:
            Console.WriteLine("Informe o valor a ser depositado");
            var valorParaDepositar = decimal.Parse(Console.ReadLine());
            contaLogada.Depositar(valorParaDepositar);
            break;
        case 3:
            Console.WriteLine("Informe o valor a ser Sacado");
            var valorParaSacar = decimal.Parse(Console.ReadLine());
            contaLogada.Sacar(valorParaSacar);
            break;
        case 4:
            contaLogada = Menu.CadastrarConta();
            Console.WriteLine(contaLogada.ToString());
            break;
    }

    Console.Clear();
}