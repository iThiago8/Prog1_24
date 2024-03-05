using static System.Console;

WriteLine("Olá, esse é um projeto de calculadora utilizando C#. Para começarmos, digite o primeiro valor:");
double num1 = Convert.ToDouble(ReadLine());

WriteLine("Agora digite qual operação você quer fazer (+, -, * ou /)");
string? operador = ReadLine();

WriteLine("Agora digite o segundo valor:");
double num2 = Convert.ToDouble(ReadLine());

double res = num1 + num2;