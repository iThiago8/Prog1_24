// See https://aka.ms/new-console-template for more information
using Atividade240318.models;

class Program 
{
    static void Main()
    {
        Cliente c1 = new Cliente();

        c1.ClienteID = 1;
        c1.Nome = "Thiago Pedro Padilha";
        c1.Email = "thiago.pedro.padilha@gmail.com";
        c1.DataNascimento = new DateTime();
        c1.Sexo = "Masculino";
        c1.CEP = "89564-346";
        c1.Rua = "Araçatuba";
        c1.Numero = 202;
        c1.Bairro = "Sesi";
        c1.Cidade = "Videira";
        c1.Estado = "Santa Catarina";
        c1.País = "Brasil";
    }
}
