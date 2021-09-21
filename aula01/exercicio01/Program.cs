using System;

//Exercicio:
//Criar um programa para ler a data de nascimento e calcular a idade da pessoa

namespace exercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            DateTime dataNascimento;
            int ano, mes, data;

            Console.Write("Digite o seu nome: ");
            nome = Console.ReadLine();
            
            Console.Write("Digite o ano de nascimento: ");
            ano = int.Parse(Console.ReadLine());
            Console.Write("Digite o mês de nascimento: ");
            mes = int.Parse(Console.ReadLine());
            Console.Write("Digite a data de nascimento: ");
            data = int.Parse(Console.ReadLine());

            dataNascimento = new DateTime(ano, mes, data);

            int auxIdade = CalcularIdade(dataNascimento);

            Console.WriteLine("Sr (a) " + nome + " sua data de Nascimento é " + dataNascimento.ToString("dd/MM/yyyy") + " a sua idade calculada é " + auxIdade);

            static int CalcularIdade(DateTime dataNascimento)
            {
                int idade = -1;
                idade = DateTime.Today.Year - dataNascimento.Year;
                return idade;
            }
        }
    }
}
