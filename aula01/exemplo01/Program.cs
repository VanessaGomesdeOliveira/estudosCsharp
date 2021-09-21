using System;

namespace exemplo01
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade = 33;
            int idadeAluno;
            string nomeAluno, sobrenomeAluno;
            bool validarIdade;
            DateTime dataNascimento;

            /* EXEMPLOS INCREMENTOS, DECREMENTOS
            idade = idade +1; // 33+1=34
            idade++; // nesse caso adiciona +1 a idade depois da leitura
            ++idade; // nesse caso adiciona +1 a idade antes da leitura
            */

            /*
            OPERADORES MATEMATICOS
            + soma
            - subtração
            / divisão
            * multiplicação
            % resto

            COMPARADORES
            && and (e)
            || or (ou)
            != diferente
            == igual

            */

            /*
            //Exemplo IF
            if (idade%2 == 0)
                Console.WriteLine("Numero par");
            else 
                Console.WriteLine("Número Impar");

            //Exemplo FOR
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i);
            }

            //Exemplo WHILE
            int x = 5;
            while (x > 0)
            {
               Console.WriteLine("X: " + x--);  
            }

            //Exemplo DO-WHILE
            int y = 5;
            do
            {
                Console.WriteLine("Y: " + y--);
            } while (y > 0);
            */

            /*  EXEMPLO SCANNER
            Console.Write("Digite o nome do Aluno: ");
            nomeAluno = Console.ReadLine();

            Console.Write("Digite o sobrenome do Aluno: ");
            sobrenomeAluno = Console.ReadLine();

            Console.Write("Digite a idade do Aluno: ");
            idadeAluno = int.Parse(Console.ReadLine());

            Console.WriteLine("Nome completo do Aluno: " + nomeAluno + " "  + sobrenomeAluno);

            Console.WriteLine("A idade do aluno: " + idadeAluno);
            */

            /* EXEMPLO TRYPARSE
            TryParse - tenta fazer uma conversão, se não for correto ele retorna False - se for correta retorna o true e devolve o valor digitado
            Console.Write("Digite a idade do Aluno: ");
            if (int.TryParse(Console.ReadLine(), out idadeAluno))
            {
                Console.WriteLine("Idade do aluno: " + idadeAluno);
            } else
            {
                Console.WriteLine(" - Valor incorreto");
            }
            */

            //EXEMPLO TRY CATCH
            try
            {
                //código
                Console.Write("Digite a Idade do Aluno: ");
                idadeAluno = int.Parse(Console.ReadLine());
                Console.WriteLine("A idade do aluno é: " + idadeAluno);
                //PARA CALCULAR A IDADE, INFORMANDO A DATA DE NASCIMENTO
                dataNascimento = new DateTime(1985, 12, 25);
                int auxIdade = CalcularIdade(dataNascimento);
                Console.WriteLine("A idade calculada é de " + auxIdade);
            }
            catch (FormatException ex)
            {
                //controle da exception
                Console.WriteLine(" - Erro no fomato da idade");
            }
            catch (RankException ex) //outro tipo de erro especifico
            {
                //controle da exception
                Console.WriteLine(" - Erro no fomato da idade");
            }
            catch (Exception ex) // esse sempre precisará ser o último
            {
                //controle de erros
                Console.WriteLine(" - Valor incorreto");
                Console.WriteLine(ex.Message);
            }

            static int CalcularIdade(DateTime dataNascimento)
            {
                int idade = -1;
                idade = DateTime.Today.Year - dataNascimento.Year;
                return idade;
            }
        }
    }
}
