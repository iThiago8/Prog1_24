WriteLine("Olá, esse é um projeto de calculadora utilizando C#. Para começarmos, digite o primeiro valor:");

double? num1 = Convert.ToDouble(ReadLine());

WriteLine("Agora digite qual operação você quer fazer (+, -, * ou /)");
string? operador = ReadLine();

WriteLine("Agora digite o segundo valor:");
double? num2 = Convert.ToDouble(ReadLine());

switch (operador)
{
    case "+":
        WriteLine($"O resultado da adição é: " + (num1 + num2));
        break;
    case "-":
        WriteLine($"O resultado da subtração é: " + (num1 - num2));
        break;
    case "*":
        WriteLine($"O resultado da multiplicação é: " + (num1 * num2));
        break;
    case "/":
        WriteLine($"O resultado da divisão é: " + (num1 / num2));
        break;
}