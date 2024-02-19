namespace BancoNovo
{
    public class Conta
    {
        public decimal Saldo { get; set; }

        public Pessoa Cliente { get; set; }

        public void Sacar(decimal valorParaSacar)
        {
            Saldo -= valorParaSacar;
        }

        public void Depositar(decimal valorParaDepositar)
        {
            Saldo += valorParaDepositar;
        }

        public void MostrarSaldo()
        {
            Console.WriteLine($"Seu saldo é: {Saldo}");
            Console.ReadKey();
        }

        public override string ToString()
        {
            return $"olá meu nome é {Cliente.Nome} tenho {Cliente.Idade} anos e meu cpf é o {Cliente.CPF}";
        }
    }
}
