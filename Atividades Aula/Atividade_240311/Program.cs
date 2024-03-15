//Escreva um programa C# que seja capaz de pergutar ao usuário um arg aritmético específico e com base na operação escolhida pelo usuário, imprima a tabuada de 1 a 9 daquela operação. Utiliza uma formatação de impressão de laço de repetição for ou while para exibir a tabuada completa dinamicamente;

internal class Program
{
    private static void Main(string[] args)
    {
        bool loop = true;
        while (loop)
        {
            string? arg;
            if (args.Length == 0)
            {
                WriteLine("Digite qual operação você quer fazer (+, -, * ou /) ou (0) para encerrar.");
                arg = ReadLine();
            } else
            {
                arg = args[0];
            }
            switch (arg)
            {
                case "+":
                    for (float p2 = 1; p2 <= 9; p2++)
                    {
                        for (float p1 = 1; p1 <= 9; p1++)
                        {
                            WriteLine($"{p1} + {p2} = {p1 + p2}");
                        }
                        WriteLine("--------------------");
                    }
                    loop = false;
                    break;
                case "-":
                    for (float p2 = 1; p2 <= 9; p2++)
                    {
                        for (float p1 = 1; p1 <= 9; p1++)
                        {
                            WriteLine($"{p1} - {p2} = {p1 - p2}");
                        }
                        WriteLine("--------------------");
                    }
                    loop = false;
                    break;
                case "*":
                    for (float p2 = 1; p2 <= 9; p2++)
                    {
                        for (float p1 = 1; p1 <= 9; p1++)
                        {
                            WriteLine($"{p1} * {p2} = {p1 * p2}");
                        }
                        WriteLine("--------------------");
                    }
                    loop = false;
                    break;
                case "/":
                    for (float p2 = 1; p2 <= 9; p2++)
                    {
                        for (float p1 = 1; p1 <= 9; p1++)
                        {
                            WriteLine($"{p1} / {p2} = {p1 / p2}");
                        }
                        WriteLine("--------------------");
                    }
                    loop = false;
                    break;
                case "0":
                    WriteLine("Você escolheu finalizar o programa.");
                    loop = false;
                    break;
                default:
                    WriteLine("Você digitou um operando inválido.");
                    break;
            }
        } 
    }
}