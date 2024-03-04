//Alteração para concluir o item 4

// Trabalhando com variáveis C#
using static System.Console;

//Comentário de marcação Aula 19/02/2024

/*
    //Inicilizar a string vazia
        //Maneira não ideal de fazer
        string message3 = "";

        //Maneira ideal
        string message4 = System.String.Empty;

    //Declararar uma string com valor implícito
    var message5 = "Mensagem aleatória";

    //Concatenando variáveis

    string concat = (message1 == null ? "" : message1)  + " " + message2 + " " + message3 + " " + message4 + " " + message5;

    WriteLine( "\n" + concat );

    WriteLine(
        "Hoje é {0:D} e a temperatura é de {1}°C."
        , DateTime.Now
        , 23 
    );

    string nome = string.Empty;
    WriteLine("Qual é o seu nome?");
    nome = ReadLine();
    string resultado = $"Oi, {nome}! Pare de jaguarice!";
    WriteLine(resultado);
*/

//Comentário de marcação Aula 26/02/2024

/*    Escreva um programa em c# que sirva como uma ficha cadastral. Tente caprichar no layout!
    Essa ficha cadastral deve coletar alguns dados do usuário:
        Nome;
        E-mail;
        Data de nascimento;
        Sexo ou gênero;
        Endereço: separado por CEP, Rua, Número, Bairro, Cidade, Unidade Federativa e País;
    Ao coletar os dados, monte um texto exibindo a ficha cadastral do indivíduo.


//Declarando variáveis para a ficha cadastral
string nome;
string email;
string dtnascimento;
string sexo;
string cep;
string rua;
string numero;
string bairro;
string cidade;
string uf;
string pais;

WriteLine("Olá, qual o seu nome?");
nome = ReadLine();

WriteLine($"Seja bem vindo, {nome}! Por favor, me informe o seu e-mail.");
email = ReadLine();

WriteLine("Ok! Agora, qual a sua data de nascimento (Favor escrever no formato dd/mm//aaaa)?");
dtnascimento = ReadLine();

WriteLine("Qual seu sexo/genêro?");
sexo = ReadLine();

WriteLine("Qual seu CEP?");
cep = ReadLine();

WriteLine("Qual sua rua?");
rua = ReadLine();

WriteLine("Qual o número da tua casa?");
numero = ReadLine();

WriteLine("Qual seu bairro?");
bairro = ReadLine();

WriteLine("Qual sua cidade?");
cidade = ReadLine();

WriteLine("Qual sua Unidade Federativa (Estado)?");
uf = ReadLine();

WriteLine("Qual seu País?");
pais = ReadLine();

string endereco = $"{cep}, {rua}, n° {numero}, {bairro} {cidade} - {uf}, {pais}.";

WriteLine(
    "---------------Ficha Cadastral---------------"
    + $"\n O seu nome é: {nome}"
    + $"\n O seu email é: {email}"
    + $"\n A sua data de nascimento é: {dtnascimento}"
    + $"\n O seu sexo é: {sexo}"
    + $"\n O seu endereço é: {endereco}"
    + "\n---------------Ficha Cadastral---------------"
);
*/

//Comentário de marcação Aula 04/03/2024

//Substituindo conteúdo de strings
    string nomeCompleto = "Thiago Pedro Padilha";
    nomeCompleto = 
        nomeCompleto.Replace("Pedro", "Pereira");
    WriteLine(nomeCompleto);

//Comparando strings
bool isNomeEqual = 
    (nomeCompleto == "Thiago Pedro Padilha");

bool isNomeEqual2 = 
    string.Equals(nomeCompleto, "Thiago Pereira Padilha");

WriteLine($"Primeiro resultado = {isNomeEqual}, Segundo resultado = {isNomeEqual2}");