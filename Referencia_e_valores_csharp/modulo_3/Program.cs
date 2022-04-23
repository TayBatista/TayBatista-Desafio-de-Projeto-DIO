using static System.Console;

Pessoa p1 = new Pessoa();

p1.Nome = "Ricardo";
p1.Idade = 25;
p1.EnderecoPessoa = new Endereco()
{
    Logradouro = "Rua teste",
    Numero = 123,
    CEP = "12345-678",
    Cidade = "São Paulo",
};

WriteLine("Fim do programa");
