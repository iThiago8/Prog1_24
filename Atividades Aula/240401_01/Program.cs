using _240401_01.Models;

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
