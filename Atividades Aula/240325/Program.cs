//Primeira Clinica
using _240325.models;

Clinica c1 = new Clinica();
Clinica.InstanceCount = 1;
c1.ObjectCount = 1;

//Segunda Clinica
Clinica c2 = new Clinica();
Clinica.InstanceCount++;
c2.ObjectCount = 10;

Console.WriteLine($"Valor c1: {c1.ObjectCount}");
Console.WriteLine($"Instance Count: {Clinica.InstanceCount}");

Console.WriteLine($"Valor c2: {c2.ObjectCount}");