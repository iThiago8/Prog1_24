using _240401_01.Models;
using _240401_01.Views;

bool aux = true;
do {
    Console.WriteLine("************************");
    Console.WriteLine("Meu pograma de pididu");
    Console.WriteLine("************************");
    Console.WriteLine();

    Console.WriteLine("1 - Clientes");
    Console.WriteLine("2 - Produtos");
    Console.WriteLine("3 - Pedidos");
    Console.WriteLine("0 - SAIR");

    int menu;

    try 
    {

        menu = Convert.ToInt32(Console.ReadLine());
        switch (menu)
        {
            case 0:
                aux = false;
                Console.WriteLine("Tmj cria, volte sempre.");
            break;

            case 1:
                CustomerView customerView = new();
            break;

            case 2:
                ProductView productView = new();
            break;

            case 3:
                OrderView orderView = new();
            break;

            default:
                Console.WriteLine("Opção inválida");
            break;
        }
    }
    catch
    {
        aux = true;
        menu = -1;
    }



} while (aux);

/*
Console.WriteLine("Hello, World!");

Customer c1 = new Customer();
c1.CustomerId = 1;
c1.Name = "Thiago";
c1.EmailAddress = "thiago@gmail.com";

Customer c2 = new Customer(2);
c2.Name = "Thiago";
c2.EmailAddress = "thiago@gmail.com";

Customer c3 = new Customer{
    Name = "Thiago",
    EmailAddress = "thiago@gmail.com",
    CustomerId = 3
};
*/