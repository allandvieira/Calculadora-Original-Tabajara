namespace CalculadoraOriginalTabajara.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();

                // Titulo da calculadora
                Console.WriteLine("Calculadora Original Tabajara em C#\r");
                Console.WriteLine("-----------------------------------\n");

                // Menu
                Console.WriteLine("Escolha uma operação matemática no Menu abaixo:");
                Console.WriteLine("\tDigite 1 para Adicionar");
                Console.WriteLine("\tDigite 2 para Subtrair");
                Console.WriteLine("\tDigite 3 para Multiplicar");
                Console.WriteLine("\tDigite 4 para Dividir");
                Console.WriteLine("\tDigite S para sair\n");

                Console.WriteLine("Qual a sua opção?\n");

                string operacao = Console.ReadLine();

                // || = comparação não obrigatória (só um precisa ser verdadeiro) 
                if (operacao == "S" || operacao == "s")
                    break;

                // && = comparação obrigatória
                if (operacao != "1" && operacao != "2" && operacao != "3" && operacao != "4" && operacao != "S" && operacao != "s")
                {
                    Console.WriteLine("\nOperação inválida, digite qualquer tecla e tente novamente...\n");
                    Console.ReadLine();

                    continue;
                }

                // Entrada do primeiro numero
                Console.WriteLine("\nDigite o primeiro número:");

                double primeiroNumero = Convert.ToDouble(Console.ReadLine());

                // Entrada do segundo numero
                Console.WriteLine("\nDigite o segundo número:");

                double segundoNumero = Convert.ToDouble(Console.ReadLine());

                double resultado = 0;

                if (operacao == "1")
                {
                    resultado = primeiroNumero + segundoNumero;
                }

                else if (operacao == "2")
                {
                    resultado = primeiroNumero - segundoNumero;
                }

                else if (operacao == "3")
                {
                    resultado = primeiroNumero * segundoNumero;
                }

                else if (operacao == "4")
                {
                    // Verifique se o segundo número é 0

                    while (segundoNumero == 0)
                    {
                        // caso for 0, pedir para o usuário digitar de novo
                        Console.WriteLine("\nSegundo número não pode ser ZERO, tente novamente!");

                        Console.ReadLine();

                        Console.WriteLine("\nDigite o segundo número novamente: ");

                        segundoNumero = Convert.ToInt32(Console.ReadLine());
                    }

                    // Caso não seja 0, divida o número
                    resultado = primeiroNumero / segundoNumero;
                }

                Console.WriteLine("\nO resultado é: " + Math.Round(resultado,2));

                // Resposta do usuário antes de fechar
                Console.WriteLine("\nPressione 'S' e Enter para fechar o aplicativo ou pressione qualquer outra tecla e Enter para continuar:\n");
                string operacao2 = Console.ReadLine();

                // || = comparação não obrigatória (só um precisa ser verdadeiro) 
                if (operacao2 == "S" || operacao2 == "s")
                    break;
                else
                {
                    continue;
                }

            }
        }
    }
}
