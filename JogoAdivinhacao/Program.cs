using System.Security.Authentication.ExtendedProtection;

namespace JogoAdivinhacao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Variáveis
            int pontos = 1000;
            int chute, totalTentativas = 0;
            
            //Gerando número aleatório
            Random random = new Random();
            int numeroSecreto = random.Next(1, 21);

            //Cabeçalho
            Console.WriteLine("BEM-VINDO(A) AO JOGO DA ADIVINHAÇÃO!");
            Console.WriteLine();
            Console.WriteLine("Escolha o nível de dificuldade: [1] Fácil [2] Médio [3] Difícil");
            Console.Write("Escolha: ");
            int dificuldade = int.Parse(Console.ReadLine());

            Console.WriteLine();

            //Processamento
            switch (dificuldade)
            {
                case 1:
                    totalTentativas = 15;
                    break;
                case 2:
                    totalTentativas = 10;
                    break;
                case 3:
                    totalTentativas = 5;
                    break;
                default: 
                    Console.WriteLine("Número inválido.");
                    Console.ReadLine();
                    break;
            }
                   
            
            for (int quantidadeChutes = 1; quantidadeChutes <= totalTentativas; quantidadeChutes++)
            {
                Console.Clear();
                
                //Input do usuário
                Console.WriteLine($"Tentativa {quantidadeChutes} de {totalTentativas}");
                Console.WriteLine("_____________________________________");
                Console.WriteLine();
                Console.Write("Qual o número de 1 a 20 você escolhe? ");
                chute = int.Parse(Console.ReadLine());

                if (chute == numeroSecreto)
                {
                    Console.Clear();
                    Console.WriteLine();
                    Console.WriteLine("Parabéns você acertou o número secreto!");
                    Console.WriteLine();
                    Console.WriteLine($"Você fez {pontos}!");
                    break;
                }
                else if (chute < numeroSecreto)
                {
                    Console.WriteLine();
                    Console.WriteLine("Putz, o número secreto é menor que o seu chute.");
                    Console.WriteLine();
                    Console.WriteLine($"Sua pontuação atual é de {pontos}.");
                }
                else if (chute > numeroSecreto)
                {
                    Console.WriteLine();
                    Console.WriteLine("Errou, o número secreto é maior que seu chute.");
                    Console.WriteLine();
                    Console.WriteLine($"Sua pontuação atual é de {pontos}.");
                }
                if (quantidadeChutes == totalTentativas)
                {
                    Console.Clear();
                    Console.WriteLine();
                    Console.WriteLine("Bah cara! Acabou suas chances, tente novamente!");
                    Console.WriteLine($"Você fez {pontos}!");
                }

                pontos = pontos - Math.Abs((chute - numeroSecreto) / 2);

                Console.ReadLine();
            }
                Console.ReadLine();
        }
    }
}