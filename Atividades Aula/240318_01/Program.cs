using _240318_01.models;

Customer c1 = new Customer();

c1.CustomerId = 1;
c1.FirstName = "Thiago";
c1.LastName = "Pedro Padilha";
c1.BirthDate = new DateTime();
c1.EmailAdress = "thiago.pedro.padilha@gmail.com";

Address address1 = new Address();
address1.AddressId = 1;
address1.Street = "Rua Araçatuba";
address1.District = "Sesi";
address1.City = "Videira";
address1.Number = 202;
address1.FederalState = "SC";
address1.Country = "Brasil";
address1.ZipCode = "89564-346";
address1.AddressType = AddressType.Commercial;

Address address2 = new Address();
address2.AddressId = 1;
address2.Street = "Rua Guilherme Mathias";
address2.District = "Matriz";
address2.City = "Videira";
address2.Number = 400;
address2.FederalState = "SC";
address2.Country = "Brasil";

c1.Addresses.Add(address1);
c1.Addresses.Add(address2);

WriteLine
(
    $"Nome: {c1.FirstName} {c1.LastName}"
    + $"\nEmail: {c1.EmailAdress}"
);

WriteLine("Endereços:");
foreach (var ad in c1.Addresses)
{
    WriteLine("---------------------------");
    WriteLine($"Rua: {ad.Street}");
    WriteLine($"Bairro: {ad.District}");
    WriteLine($"Cidade: {ad.City}");
    WriteLine($"Estado: {ad.FederalState}");
    WriteLine($"País: {ad.Country}");
}