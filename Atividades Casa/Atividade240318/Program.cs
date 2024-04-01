// See https://aka.ms/new-console-template for more information
using Atividade240318.Models;

class Program 
{
    static void Main()
    {
        Imovel i1 = new Imovel();
        i1.Nome = "Ilha de Creta";        
        i1.ImovelId = 1;
        i1.Categoria = Categoria.Apartamento;
        i1.Localidade = Localidade.Urbano;
        i1.TipoNegocio = TipoNegocio.Locacacao;
        i1.Descricao = "Condomínio de apartamentos para locação";
        i1.Valor = 2000.00;
        i1.NumeroComodos = 4;

        Console.WriteLine
        (
            $"O imovel {i1.Nome}, é de categoria {i1.Categoria}, localidade {i1.Localidade}, sendo de {i1.TipoNegocio}, no valor de R${i1.Valor}, possuindo {i1.NumeroComodos} cômodos. \nDescrição: {i1.Descricao}"
        );
    }
}
