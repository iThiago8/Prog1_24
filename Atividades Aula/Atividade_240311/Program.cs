// See https://aka.ms/new-console-template for more information
//Escreva um programa C# que seja capaz de pergutar ao usuário um operador aritmético específico e com base na operação escolhida pelo usuário, imprima a tabuada de 1 a 9 daquela operação. Utiliza uma formatação de impressão de laço de repetição for ou while para exibir a tabuada completa dinamicamente;

WriteLine("Agora digite qual operação você quer fazer (+, -, * ou /)");
string? operador = ReadLine();


switch (operador)
{
    case "+":
        for (int p2 = 1; p2 <= 9; p2++)
        {
            for (int p1 = 1; p1 <= 9; p1++)
            {
                WriteLine($"{p1} + {p2} = {p1 + p2}");
            }
            WriteLine("--------------------");
        }
        break;
    case "-":
        for (int p2 = 1; p2 <= 9; p2++)
        {
            for (int p1 = 1; p1 <= 9; p1++)
            {
                WriteLine($"{p1} - {p2} = {p1 - p2}");
            }
            WriteLine("--------------------");
        }
        break;
    case "*":
        for (int p2 = 1; p2 <= 9; p2++)
        {
            for (int p1 = 1; p1 <= 9; p1++)
            {
                WriteLine($"{p1} * {p2} = {p1 * p2}");
            }
            WriteLine("--------------------");
        }
        break;
    case "/":
        for (int p2 = 1; p2 <= 9; p2++)
        {
            for (int p1 = 1; p1 <= 9; p1++)
            {
                WriteLine($"{p1} / {p2} = {p1 / p2}");
            }
            WriteLine("--------------------");
        }
        break;
    default:
        WriteLine("Você digitou um operando inválido.");
        break;
}
