using System.Text.RegularExpressions;

namespace BancoNovo
{
    public static class Menu
    {
        public static void BoasVindas()
        {
            Console.WriteLine("Bem vindo ao Bracosk");
        }

        public static void MostrarMenu()
        {
            Console.WriteLine("Escolha uma opção");
            Console.WriteLine("1 - Mostrar saldo");
            Console.WriteLine("2 - Depositar");
            Console.WriteLine("3 - Sacar");
            Console.WriteLine("4 - Cadastrar");
            Console.WriteLine("0 - Para Sair");
            Console.WriteLine("Digite Sua Opção: ");
        }

        public static Conta CadastrarConta()
        {
            Console.WriteLine("Informe seu nome");
            var nome = Console.ReadLine();

            Console.WriteLine("Informe sua idade");
            var idade = int.Parse(Console.ReadLine());
            var cpf = "";
            do
            {
                Console.WriteLine("Informe seu CPF");
                cpf = Console.ReadLine();

            } while (!Regex.IsMatch(cpf, @"^[0-9]+$"));
            


            Console.WriteLine("Informe seu saldo inicial");
            var saldo = decimal.Parse(Console.ReadLine());

            return new Conta
            {
                Saldo = saldo,
                Cliente = new Pessoa
                {
                    Nome = nome,
                    Idade = idade,
                    CPF = cpf
                }
            };
        }
    }
}
