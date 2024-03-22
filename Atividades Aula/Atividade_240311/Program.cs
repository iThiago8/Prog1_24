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
                arg = Convert.ToString(args[0]);
            }
            switch (arg)
            {
                case "+":
                case "-":
                case "*":
                case "/":
                    MostrarTabuada(arg);
                    loop = false;
                    break;
                case "0":
                    WriteLine("Você escolheu finalizar o programa.");
                    loop = false;
                    break;
                default:
                    WriteLine("Você digitou um operando inválido");
                    break;
            }
        }
    }
    private static void MostrarTabuada(string operador)
    {
        WriteLine($"Tabuada do operador '{operador}':");
        for (float f2 = 1; f2 <= 9; f2++)
        {
            for (float f1 = 1; f1 <= 9; f1++)
            {
                float resultado = 0;
                switch (operador)
                {
                    case "+":
                        resultado = f1 + f2;
                        break;
                    case "-":
                        resultado = f1 - f2;
                        break;
                    case "*":
                        resultado = f1 * f2;
                        break;
                    case "/":
                        resultado = f1 / f2;
                        break;
                }
                WriteLine($"{f1} {operador} {f2} = {resultado}");              
            }
            WriteLine("-------------------");
        }   
    }
}