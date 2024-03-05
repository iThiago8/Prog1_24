/*    Escreva um programa em c# que sirva como uma ficha cadastral. Tente caprichar no layout!
    Essa ficha cadastral deve coletar alguns dados do usuário:
        Nome;
        E-mail;
        Data de nascimento;
        Sexo ou gênero;
        Endereço: separado por CEP, Rua, Número, Bairro, Cidade, Unidade Federativa e País;
    Ao coletar os dados, monte um texto exibindo a ficha cadastral do indivíduo.
*/

//Declarando variáveis para a ficha cadastral
string? nome;
string? email;
string? dtnascimento;
string? sexo;
string? cep;
string? rua;
string? numero;
string? bairro;
string? cidade;
string? uf;
string? pais;

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
