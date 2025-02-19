using System;

namespace Aula01Variaveis
{
    public class Program
    {
        static void Main(string[] args)
        {
            int opcaoEscolhida = 0;

            do
            {
                Console.WriteLine("====================================================================");
                Console.WriteLine("*********************** Exercícios - Aula 01 ***********************");
                Console.WriteLine("====================================================================");
                Console.WriteLine("Observe o menu abaixo e digite o número referente a opção desejada: ");
                Console.WriteLine("1 - Concatenar Palavras");
                Console.WriteLine("2 - Verificar Dia da Semana");
                Console.WriteLine("3 - Calcular Média");
                Console.WriteLine("4 - Calcular Tabuada");                                
                Console.WriteLine("====================================================================");
                Console.WriteLine("---------------Ou tecle qualquer outro número para sair ------------");
                Console.WriteLine("====================================================================");

                opcaoEscolhida = int.Parse(Console.ReadLine());

                switch (opcaoEscolhida)
                {
                    case 1:
                        ConcatenarPalavras();
                        break;
                    case 2:
                        VerificarAulaEtec();
                        break;
                    case 3:
                        CalcularMedia();
                        break;
                    case 4:                    
                        CalcularTabuada();
                        break;                                       
                    default:
                        Console.WriteLine("Saindo do sistema....");
                        break;
                }
            } while (opcaoEscolhida >= 1 && opcaoEscolhida <= 6);

            Console.WriteLine("====================================================================");
            Console.WriteLine("********** Obrigado por utilizar o sistema e volte sempre **********");
            Console.WriteLine("====================================================================");
            Console.WriteLine("");Console.WriteLine("");  
        }

        //Método aqui

        public static void ConcatenarPalavras()
        {
            Console.WriteLine("Digite o seu nome");
            string nome = Console.ReadLine();
            string frase1 = $"Olá {nome}, hoje é {DateTime.Now}";
            Console.WriteLine(frase1);
            Console.WriteLine("===============================");

            Console.WriteLine("Quanto custa um dólar em reais?");
            decimal valorDolarReais = decimal.Parse(Console.ReadLine());
            string frase2 =
                string.Format("Hoje é {0:dd/MM/yyyy}, o dólar está custando {1:c2}", DateTime.Now, valorDolarReais);
            Console.WriteLine(frase2);
            Console.WriteLine("===============================");

            string cabecalho = string.Format("{0:dddd}, {0:dd} de {0:MMMM} de {0:yy} - {0:HH:mm:ss}", DateTime.Now);
            Console.WriteLine(cabecalho);
        }

       

        public static void VerificarAulaEtec()
        {
            Console.WriteLine("Digite a data");
            DateTime data = DateTime.Parse(Console.ReadLine());

            if (data.DayOfWeek == DayOfWeek.Saturday || data.DayOfWeek == DayOfWeek.Sunday)
            {
                Console.WriteLine("Final de semana! Hoje não tem aula! Revisarei exercícios");
            }
            else
            {
                Console.WriteLine("Dia da semana! Bora pra Etec");
            }
        }

        public static void CalcularMedia()
        {
            Console.WriteLine("Digite a primeira nota");
            decimal nota1 = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Digite a segunda nota");
            decimal nota2 = decimal.Parse(Console.ReadLine());

            decimal media = (nota1 + nota2) / 2;
            Console.WriteLine($"A média é {media}");

            if (media >= 7)
                Console.WriteLine("Aprovado");
            else if (media < 7 && media >= 4)
                Console.WriteLine("Recuperação");
            else
                Console.WriteLine("Reprovado");
        }

        public static void CalcularTabuada()
        {
            Console.WriteLine("Digite a tabuada que deseja calular");
            int tabuada = int.Parse(Console.ReadLine());
            int contador = 0;

            while (contador <= 10)
            {
                string mensagem = string.Format("{0} X {1} = {2}", tabuada, contador, tabuada * contador);
                Console.WriteLine(mensagem);
                contador++;
            }
        }








    }
}